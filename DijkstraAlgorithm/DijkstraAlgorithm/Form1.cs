using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace DijkstraTest2
{
    public partial class Form1 : Form
    {
        Graph g = new Graph();

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
            btnRun.Click += btnRun_Click;
            southMap.Paint += southMap_Paint; // southMap là PictureBox để vẽ bản đồ
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            string[] cities = { "Đồng Nai", "TP. Hồ Chí Minh", "Tây Ninh", "Đồng Tháp", "An Giang", "Vĩnh Long", "TP. Cần Thơ", "Cà Mau" };
            foreach (string city in cities)
            {
                g.AddVertex(city);
            }
            AddEdgesToGraph();
        }

        //Chèn quãng đường di chuyển giữa các tỉnh, thành phố
        public void AddEdgesToGraph()
        {
            g.AddEdge(0, 1, 36); // Đồng Nai - TP. Hồ Chí Minh
            g.AddEdge(0, 2, 75); // Đồng Nai - Tây Ninh
            g.AddEdge(1, 2, 47); // TP. Hồ Chí Minh - Tây Ninh
            g.AddEdge(2, 3, 20); // Tây Ninh - Đồng Tháp
            g.AddEdge(3, 4, 180); // Đồng Tháp - An Giang
            g.AddEdge(3, 5, 70); // Đồng Tháp - Vĩnh Long
            g.AddEdge(3, 6, 106); // Đồng Tháp - TP. Cần Thơ
            g.AddEdge(5, 6, 46); // Vĩnh Long - TP. Cần Thơ
            g.AddEdge(7, 4, 126); // Cà Mau - An Giang
            g.AddEdge(6, 4, 95); // TP. Cần Thơ - An Giang
            g.AddEdge(6, 7, 137); // TP. Cần Thơ - Cà Mau
        }

        //Vẽ bản đồ
        public void southMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics gPanel = e.Graphics;
            DrawAllEdges(gPanel);
            for (int i = 0; i < g.nVerts; i++)
            {
                Point center = GetCityPoint(i);
                gPanel.FillEllipse(Brushes.SeaGreen, center.X - 5, center.Y - 5, 10, 10);
            }
            List<int> path = g.GetLastPath();
            DrawPathLine(gPanel, path);
        }
        //Vẽ các điểm trung tâm hành chính của mỗi tỉnh, thành phố tương ứng
        public Point GetCityPoint(int index)
        {
            Point[] points = new Point[]
            {
                new Point(318, 130), // Đồng Nai
                new Point(293, 146), // TP.HCM
                new Point(281, 176), // Tây Ninh
                new Point(244, 181), // Đồng Tháp
                new Point(135, 215), // An Giang
                new Point(222, 215), // Vĩnh Long
                new Point(223, 252), // TP. Cần Thơ
                new Point(140, 317), // Cà Mau
            };

            if (index < 0 || index >= points.Length)
            {
                Console.WriteLine($"Lỗi: Chỉ số thành phố không hợp lệ ({index}).");
                return Point.Empty;
            }

            return points[index];
        }
        //Vẽ đường đi giữa các trung tâm hành chính mỗi tỉnh, thành phố
        public void DrawAllEdges(Graphics gPanel)
        {
            for (int i = 0; i < g.nVerts; i++)
            {
                for (int j = 0; j < g.nVerts; j++)
                {
                    if (g.adjMat[i, j] != g.infinity)
                    {
                        if (i >= 0 && i < g.nVerts && j >= 0 && j < g.nVerts)
                        {
                            Point p1 = GetCityPoint(i);
                            Point p2 = GetCityPoint(j);
                            if (p1 != Point.Empty && p2 != Point.Empty)
                            {
                                gPanel.DrawLine(Pens.Black, p1, p2);
                            }
                        }
                    }
                }
            }
        }
        //Vẽ đường đi ngắn nhất sau khi tính toán
        public void DrawPathLine(Graphics gPanel, List<int> path)
        {
            if (path == null || path.Count < 2) return;
            Pen pen = new Pen(Color.AliceBlue, 3);
            for (int i = 0; i < path.Count - 1; i++)
            {
                if (path[i] < g.nVerts && path[i + 1] < g.nVerts)
                {
                    Point p1 = GetCityPoint(path[i]);
                    Point p2 = GetCityPoint(path[i + 1]);
                    if (p1 != Point.Empty && p2 != Point.Empty)
                        gPanel.DrawLine(pen, p1, p2);
                }
            }
        }
        //Nút "Tính toán"
        public void btnRun_Click(object sender, EventArgs e)
        {
            int from = cbSource.SelectedIndex;
            int to = cbDestination.SelectedIndex;

            if (from < 0 || to < 0)
            {
                MessageBox.Show("Vui lòng chọn cả điểm đi và điểm đến.");
                return;
            }
            if (cbSource.SelectedItem == cbDestination.SelectedItem)
            {
                MessageBox.Show("Điểm bắt đầu và kết thúc không được giống nhau.");
                return;
            }

            string startLabel = cbSource.SelectedItem.ToString();
            string endLabel = cbDestination.SelectedItem.ToString();

            int startIndex = g.GetIndexByLabel(startLabel);
            int endIndex = g.GetIndexByLabel(endLabel);

            if (startIndex == -1 || endIndex == -1)
            {
                MessageBox.Show("Không tìm thấy địa điểm đã chọn trong danh sách đỉnh.");
                return;
            }

            g.Dijkstra(startIndex);
            g.FindPath(startIndex, endIndex, tbKM, tbLiter, tbCost, tbPath);
            southMap.Invalidate(); // Gọi lại Paint
        }
    }
}





