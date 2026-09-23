using System.Collections.Generic;
using System.Windows.Forms;
using System;
using System.Linq;

public class DistOriginal
{
    public int distance;
    public int parentVert;
    public DistOriginal(int pv, int d)
    {
        distance = d;
        parentVert = pv;
    }
}

public class Vertex
{
    public string label;
    public bool isInTree;
    public Vertex(string lab)
    {
        label = lab;
        isInTree = false;
    }
}

public class Graph
{
    public const int max_verts = 20;
    public int infinity = 1000000;
    public Vertex[] vertexList = new Vertex[max_verts];
    public int[,] adjMat = new int[max_verts, max_verts];
    public int nVerts = 0;
    public int nTree;
    public DistOriginal[] sPath = new DistOriginal[max_verts];
    public int currentVert;
    public int startToCurrent;
    private List<int> lastPath = new List<int>();

    public Graph()
    {
        for (int i = 0; i < max_verts; i++)
            for (int j = 0; j < max_verts; j++)
                adjMat[i, j] = infinity;
    }

    public void AddVertex(string lab)
    {
        if (nVerts >= max_verts)
            throw new InvalidOperationException("Vượt quá số đỉnh cho phép.");
        vertexList[nVerts++] = new Vertex(lab);
    }

    public void AddEdge(int start, int end, int weight, bool bidirectional = true)
    {
        if (start >= 0 && start < nVerts && end >= 0 && end < nVerts)
        {
            adjMat[start, end] = weight;
            if (bidirectional)
                adjMat[end, start] = weight;
        }
    }

    public int GetIndexByLabel(string label)
    {
        for (int i = 0; i < nVerts; i++)
            if (vertexList[i].label.Equals(label, StringComparison.OrdinalIgnoreCase))
                return i;
        return -1;
    }

    public void Dijkstra(int startIndex)
    {
        for (int i = 0; i < nVerts; i++)
            vertexList[i].isInTree = false;
        vertexList[startIndex].isInTree = true;
        nTree = 1;
        for (int j = 0; j < nVerts; j++)
            sPath[j] = new DistOriginal(startIndex, adjMat[startIndex, j]);
        sPath[startIndex].distance = 0;
        while (nTree < nVerts)
        {
            int indexMin = GetMin();
            if (sPath[indexMin].distance == infinity)
                break;
            currentVert = indexMin;
            startToCurrent = sPath[indexMin].distance;
            vertexList[currentVert].isInTree = true;
            nTree++;
            AdjustShortPath();
        }
    }

    public int GetMin()
    {
        int minDist = infinity;
        int indexMin = 0;
        for (int j = 0; j < nVerts; j++)
            if (!vertexList[j].isInTree && sPath[j].distance < minDist)
            {
                minDist = sPath[j].distance;
                indexMin = j;
            }
        return indexMin;
    }

    public void AdjustShortPath()
    {
        for (int column = 0; column < nVerts; column++)
        {
            if (vertexList[column].isInTree) continue;
            int currentToFringe = adjMat[currentVert, column];
            if (currentToFringe == infinity) continue;
            int startToFringe = startToCurrent + currentToFringe;
            if (startToFringe < sPath[column].distance)
            {
                sPath[column].distance = startToFringe;
                sPath[column].parentVert = currentVert;
            }
        }
    }

    public void FindPath(int s, int v, TextBox tbKM, TextBox tbLiter, TextBox tbCost, TextBox tbPath)
    {
        lastPath.Clear();
        List<int> path = new List<int>();
        int km = 0;
        tbPath.Clear();
        try
        {
            int current = v;
            while (current != s)
            {
                int prev = sPath[current].parentVert;
                if (prev == -1 || sPath[current].distance == infinity)
                {
                    MessageBox.Show("Không tìm thấy đường đi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                path.Add(current);
                km += adjMat[prev, current];
                current = prev;
            }
            path.Add(s);
            path.Reverse();
            lastPath = new List<int>(path);

            List<string> labels = new List<string>();
            foreach (int i in path)
            {
                if (i >= 0 && i < vertexList.Length && vertexList[i] != null)
                {
                    labels.Add(vertexList[i].label);
                }
                else
                {
                    labels.Add("[Không xác định]");
                }
            }
            tbPath.Text = string.Join(" -> ", labels);

            double liters = Math.Round(km * 0.09, 2);
            double cost = Math.Round(km * 0.09 * 19.179, 2);
            tbKM.Text = $"{km} KM";
            tbLiter.Text = $"{liters} liters";
            tbCost.Text = $"{cost} VNĐ";
        }
        catch (Exception ex)
        {
            MessageBox.Show("Lỗi khi tính đường đi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    public List<int> GetLastPath()
    {
        return lastPath;
    }
}


