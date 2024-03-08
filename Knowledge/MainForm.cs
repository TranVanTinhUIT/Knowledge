using Accessibility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Knowledge
{
    public partial class MainForm : Form
    {
        private List<Point> objectPositions = new List<Point>();

        private List<System.Drawing.Rectangle> rectangles = new List<System.Drawing.Rectangle>();

        public MainForm()
        {
            InitializeComponent();
            InitializeObjects();
        }

        private void InitializeObjects()
        {
            // Thêm các vị trí của đối tượng vào danh sách
            objectPositions.Add(new Point(100, 100));
            objectPositions.Add(new Point(200, 150));
            objectPositions.Add(new Point(150, 250));

            rectangles.Add(new Rectangle(100, 120, 10, 10));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = MainPanel.CreateGraphics();

            // Vẽ các đối tượng
            foreach (Point point in objectPositions)
            {
                g.FillEllipse(Brushes.Blue, point.X - 20, point.Y - 20, 40, 40);
            }

            // Vẽ các liên kết giữa các đối tượng
            if (objectPositions.Count >= 2)
            {
                Pen pen = new Pen(Color.Black, 2);
                for (int i = 0; i < objectPositions.Count - 1; i++)
                {
                    g.DrawLine(pen, objectPositions[i], objectPositions[i + 1]);
                }
            }
        }


        private void btnAddCompound_Click(object sender, EventArgs e)
        {
            var addCompoundForm = new AddCompoundForm();
            var dialogResult = addCompoundForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                
            }
        }

        private void btnAddRule_Click(object sender, EventArgs e)
        {
            var addRuleForm = new AddRuleForm();
            var dialogResult = addRuleForm.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {

            }
        }
    }
}
