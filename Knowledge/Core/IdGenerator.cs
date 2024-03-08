using System.Diagnostics;
using System.Net.NetworkInformation;

public static class IdGenerator
{
    private static Random R = new Random();

    // ID can generate for 291 years from StartTime.
    private static readonly long StartTime = new DateTime(2020, 1, 1).Ticks;

    private static long CurrentTimestamp = 0;
    private static volatile short CurrentSequence = 0;
    private static object SyncLock = new object();

    /// <summary>
    /// Cluster ID. To avoid id conflict, each process should have different cluster ID.
    /// By default, cluster ID is generated automatically base on ProcessID and MAC Address.
    /// </summary>
    public static short ClusterId = GenerateClusterId();

    /// <summary>
    /// Generate new global unique ID
    /// </summary>
    /// <returns></returns>
    public static long NewId()
    {
        // XX12345678000_CCC_SSS
        // XX12345678000: First 13 digits of miliseconds Timestamp from StartTime
        // CCC: ClusterId
        // SSS: Sequence (in case in the same milisecond more than one ID created.  In case more than 999 IDs generated at same milisecond, NewId will step for 1 milisecond

        lock (SyncLock)
        {
            var currentTimestamp = Interlocked.Read(ref CurrentTimestamp);
            var currentSequence = CurrentSequence;

            var timeStamp = (DateTime.UtcNow.Ticks - StartTime) / TimeSpan.TicksPerMillisecond;
            if (currentTimestamp != timeStamp)
            {
                currentTimestamp = timeStamp;
                currentSequence = (short)R.Next(0, 500);
            }
            else
            {
                currentSequence = (short)(CurrentSequence + 1);
                if (currentSequence > 999)
                {
                    currentSequence = (short)R.Next(0, 500);
                    currentTimestamp++;
                    Thread.Sleep(1);
                }
            }
            CurrentSequence = currentSequence;
            Interlocked.Exchange(ref CurrentTimestamp, currentTimestamp);

            return (currentTimestamp * 1_000_000) +
                (ClusterId * 1000) +
                currentSequence;
        }
    }

    private static short GenerateClusterId()
    {
        long macAddress = 0;
        try
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.OperationalStatus == OperationalStatus.Up)
                {
                    var macAddrBytes = nic.GetPhysicalAddress().GetAddressBytes();
                    var int64temp = BitConverter.GetBytes((long)0);
                    macAddrBytes.CopyTo(int64temp, int64temp.Length - macAddrBytes.Length);
                    macAddress = BitConverter.ToInt64(int64temp, 0);
                }
            }
        }
        catch
        {
            // ignore
        }

        if (macAddress == 0)
        {
            macAddress = R.Next(100_000, 999_999);
        }

        int processId = Process.GetCurrentProcess().Id;
        if (processId == 0)
        {
            processId = R.Next(10_000, 99_999);
        }

        return (short)(((macAddress * 7) + ((long)processId * 6997)) % 1000);
    }
}
