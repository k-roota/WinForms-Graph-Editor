using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;

namespace lab7
{
    [Serializable] class Graph
    {
        private List<Vertex> vertices = new List<Vertex>();
        private List<Edge> edges = new List<Edge>();
        [NonSerialized] private int? selected;

        public List<Vertex> Vertices { get => vertices; }
        public List<Edge> Edges { get => edges; }
        public int? Selected { get => selected; set => selected = value; }

        public bool AddVertex(Vertex vertex)
        {
            foreach (Vertex v in Vertices)
            {
                if (v.Collides(vertex))
                    return false;
            }
            Vertices.Add(vertex);
            return true;
        }

        public void Save(string path)
        {
            var fs = new FileStream(path, FileMode.Create);
            var bf = new BinaryFormatter();
            bf.Serialize(fs, this);
            fs.Close();
        }

        static public Graph Load(string path)
        {
            Graph graph = null;
            FileStream fs = null;
            try
            {
                fs = new FileStream(path, FileMode.Open);
                var bf = new BinaryFormatter();
                graph = (Graph)bf.Deserialize(fs);
            }
            finally
            {
                if(fs != null)
                {
                    fs.Close();
                }
            }
            return graph;
        }

        public void Clear()
        {
            vertices.Clear();
            edges.Clear();
            selected = null;
        }

        public int? VertexOnPos(Point pos)
        {
            int? vID = null;
            int minDist = int.MaxValue;
            for (int i = 0; i < vertices.Count; i++)
            {
                Vertex v = vertices[i];
                int dist = v.DistanceSquare(pos);
                if (dist <= Math.Pow(v.Rad, 2))
                {
                    if(dist < minDist)
                    {
                        vID = i;
                        minDist = dist;
                    }
                }
            }
            return vID;
        }

        public void RemoveSelected()
        {
            edges.RemoveAll(e => e.To == selected || e.From == selected);
            foreach(Edge e in edges)
            {
                if(e.From > selected)
                {
                    e.From--;
                }
                if(e.To > selected)
                {
                    e.To--;
                }
            }
            vertices.RemoveAt(selected.Value);
            selected = null;
        }

        public int? FindEdge(int from, int to)
        {
            Edge pattern = new Edge(from, to);
            for(int i=0; i<edges.Count; i++)
            {
                Edge e = edges[i];
                if (e.Equals(pattern))
                {
                    return i;
                }
            }
            return null;
        }

        public void AddEdge(int from, int to)
        {
            Edge newEdge = new Edge(from, to);
            edges.Add(newEdge);
        }

        public void RemoveEdge(int eID)
        {
            edges.RemoveAt(eID);
        }
    }

    [Serializable] class Edge
    {
        private int from;
        private int to;

        public int From { get => from; set => from = value; }
        public int To { get => to; set => to = value; }

        public Edge(int from, int to)
        {
            this.to = to;
            this.from = from;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Edge))
                return false;
            Edge e = obj as Edge;
            return (e.from == from && e.to == to) || (e.from == to && e.to == from);
        }

        public override int GetHashCode()
        {
            var hashCode = -1951484959;
            hashCode = hashCode * -1521134295 + from.GetHashCode();
            hashCode = hashCode * -1521134295 + to.GetHashCode();
            return hashCode;
        }
    }
}
