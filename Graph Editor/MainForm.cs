using System;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Globalization;

namespace lab7
{
    public partial class GraphEditorForm : Form
    {
        Graph graph = new Graph();
        bool isMoved = false;
        Point prevPos;

        public GraphEditorForm()
        {
            InitializeComponent();
            InitProperties();
        }

        private void InitProperties()
        {
            string filter = "Graph files (*.graph)|*.graph";
            openFileDialog.Filter = filter;
            saveFileDialog.Filter = filter;
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            int? vID = graph.VertexOnPos(e.Location);
            if (e.Button == MouseButtons.Left)
            {
                if(graph.Selected != null && vID != null)
                {
                    int? edgeID = graph.FindEdge(graph.Selected.Value, vID.Value);
                    if(edgeID == null)
                    {
                        graph.AddEdge(graph.Selected.Value, vID.Value);
                    }
                    else
                    {
                        graph.RemoveEdge(edgeID.Value);
                    }
                    pictureBox.Invalidate();
                }
                else
                {
                    Vertex v = new Vertex(e.Location, colorPanel.BackColor);
                    graph.AddVertex(v);
                }
                pictureBox.Invalidate();
            }
            else if(e.Button == MouseButtons.Right)
            {
                if(isMoved && graph.Selected != null)
                {
                    CorrectMove();
                }
                if (vID != null)
                {
                    removeButton.Enabled = true;
                }
                else
                {
                    removeButton.Enabled = false;
                    isMoved = false;
                }
                graph.Selected = vID;
                pictureBox.Invalidate();
            }
            else if(e.Button == MouseButtons.Middle)
            {
                if(graph.Selected != null)
                {
                    isMoved = true;
                    prevPos = e.Location;
                }
            }
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            int lineWidth = 3;
            Pen edgePen = new Pen(Color.Black, lineWidth);
            foreach (Edge edge in graph.Edges)
            {
                e.Graphics.DrawLine(edgePen, graph.Vertices[edge.From].Pos, graph.Vertices[edge.To].Pos);
            }
            edgePen.Dispose();
            StringFormat format = new StringFormat();
            format.LineAlignment = StringAlignment.Center;
            format.Alignment = StringAlignment.Center;
            for(int i=0; i<graph.Vertices.Count; i++)
            {
                Vertex v = graph.Vertices[i];
                Pen pen = new Pen(v.Color, lineWidth);
                if(i == graph.Selected)
                {
                    pen.DashPattern = new float[] { 1.5f, 1.5f };
                }
                SolidBrush brush = new SolidBrush(v.Color);
                Rectangle rect = new Rectangle((int)(v.Pos.X - v.Rad), (int)(v.Pos.Y - v.Rad), v.Rad * 2, v.Rad * 2);
                e.Graphics.FillEllipse(Brushes.White, rect);
                e.Graphics.DrawEllipse(pen, rect);
                e.Graphics.DrawString((i+1).ToString(), new Font("Arial", 10), brush, rect, format);
                pen.Dispose();
                brush.Dispose();
            }
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == colorDialog.ShowDialog())
            {
                colorPanel.BackColor = colorDialog.Color;
                if(graph.Selected != null)
                {
                    graph.Vertices[graph.Selected.Value].Color = colorDialog.Color;
                    pictureBox.Invalidate();
                }
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == saveFileDialog.ShowDialog())
            {
                graph.Save(saveFileDialog.FileName);
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            if(DialogResult.OK == openFileDialog.ShowDialog())
            {
                try
                {
                    graph = Graph.Load(openFileDialog.FileName);
                    pictureBox.Invalidate();
                    if(graph.Selected == null)
                    {
                        removeButton.Enabled = false;
                    }
                    else
                    {
                        removeButton.Enabled = true;
                    }
                }
                catch(System.Runtime.Serialization.SerializationException)
                {
                    ComponentResourceManager crm = new ComponentResourceManager(this.GetType());
                    MessageBox.Show(crm.GetString("incorrect file"), crm.GetString("error"));
                }
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            graph.Clear();
            removeButton.Enabled = false;
            pictureBox.Invalidate();
        }

        private void RemoveSelected()
        {
            graph.RemoveSelected();
            removeButton.Enabled = false;
            pictureBox.Invalidate();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            RemoveSelected();
        }

        private void GraphEditorForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (graph.Selected != null)
                {
                    RemoveSelected();
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(isMoved)
            {
                if(graph.Selected != null)
                {
                    Point vector = new Point(e.Location.X - prevPos.X, e.Location.Y - prevPos.Y);
                    prevPos = e.Location;
                    Vertex v = graph.Vertices[graph.Selected.Value];
                    vector.X += v.Pos.X;
                    vector.Y += v.Pos.Y;
                    v.Pos = vector;
                    pictureBox.Invalidate();
                }
                else
                {
                    isMoved = false;
                }
            }
        }

        private void CorrectMove()
        {
            Vertex v = graph.Vertices[graph.Selected.Value];
            Point newPos = v.Pos;
            if (newPos.X < 0)
                newPos.X = 0;
            else if (newPos.X > pictureBox.Size.Width)
                newPos.X = pictureBox.Size.Width;
            if (newPos.Y < 0)
                newPos.Y = 0;
            else if (newPos.Y > pictureBox.Size.Height)
                newPos.Y = pictureBox.Size.Height;
            v.Pos = newPos;
            pictureBox.Invalidate();
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
            {
                if (isMoved)
                {
                    isMoved = false;
                    if (graph.Selected != null)
                    {
                        CorrectMove();
                    }
                }
            }
        }

        private void polishButton_Click(object sender, EventArgs e)
        {
            ChangeCulture(new CultureInfo("pl-PL"));
        }

        private void englishButton_Click(object sender, EventArgs e)
        {
            ChangeCulture(new CultureInfo("en-GB"));
        }

        private void ChangeCulture(CultureInfo culture)
        {
            ComponentResourceManager crm = new ComponentResourceManager(this.GetType());
            Thread.CurrentThread.CurrentUICulture = culture;
            this.SuspendLayout();
            crm.ApplyResources(this, this.Name);
            ApplyResources(this, crm);
            this.ResumeLayout();
            this.Invalidate();
        }

        private void ApplyResources(Control parent, ComponentResourceManager crm)
        {
            foreach (Control control in parent.Controls)
            {
                crm.ApplyResources(control, control.Name);
                ApplyResources(control, crm);
            }
        }
    }
}
