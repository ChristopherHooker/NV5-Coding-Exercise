using IronXL;
using NV5_Coding_Exercise.Entities;
using System.Data;

namespace NV5_Coding_Exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadQueriesButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dataGridView1.DataSource = dt; //Make sure the gridview reloads the columns in the correct order

            try
            {
                //Read buildings and queries from excel sheets
                List<Building> buildings = ExcelSheetToBuildings(BuildingsTextBox.Text);
                List<Location> queryLocations = ExcelSheetToLocations(QueriesTextBox.Text);

                //Build Columns in data table
                dt.Columns.Add("Name");
                dt.Columns.Add("X");
                dt.Columns.Add("Y");
                if(calculate3dCheckbox.Checked) dt.Columns.Add("Elevation"); //Only display elevation if checking in 3D
                dt.Columns.Add("Nearest Building");
                dt.Columns.Add("Distance");
                if (additionalInfoCheckBox.Checked) {
                    dt.Columns.Add("Floors");
                    dt.Columns.Add("Height");
                    dt.Columns.Add("Year");
                    dt.Columns.Add("Rank");
                    dt.Columns.Add("Notes");
                }

                foreach(Location location in queryLocations)
                {
                    DataRow dr = dt.NewRow();
                    dr["Name"] = location.Name;
                    dr["X"] = location.Coordinate_X;
                    dr["Y"] = location.Coordinate_Y;
                    if (calculate3dCheckbox.Checked) dr["Elevation"] = location.Elevation; //only display elevation if checking in 3D
                    Building nearestBuilding = GetNearestBuilding(buildings, location);
                    dr["Nearest Building"] = nearestBuilding.Name;
                    dr["Distance"] = location.calculateDistance(nearestBuilding, calculate3dCheckbox.Checked);
                    if(additionalInfoCheckBox.Checked)
                    {
                        dr["Floors"] = nearestBuilding.Floors;
                        dr["Height"] = nearestBuilding.Height;
                        dr["Year"] = nearestBuilding.Year;
                        dr["Rank"] = nearestBuilding.Rank;
                        dr["Notes"] = nearestBuilding.Notes;
                    }
                    dt.Rows.Add(dr);
                }

                dataGridView1.DataSource = dt;
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QueriesSelectButton_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    QueriesTextBox.Text = filePath;
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BuildingsSelectButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string filePath = openFileDialog1.FileName;
                    BuildingsTextBox.Text = filePath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadBuildingsButton_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string filePath = BuildingsTextBox.Text;
            List<Building> buildings = ExcelSheetToBuildings(filePath);

            try
            {
                

                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Converts an excelsheet at the given filePath into a List of type Building
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private List<Building> ExcelSheetToBuildings(string filePath)
        {
            //Load up the workbook data
            WorkBook wb = WorkBook.LoadCSV(filePath);
            WorkSheet ws = wb.DefaultWorkSheet;
            var rows = ws.Rows;

            List<Building> buildings = new List<Building>();
            List<String> headers = new List<String>();

            // Get Excel Sheet Headers For Indexing
            foreach(Cell cell in rows.First().ToList()) headers.Add(cell.Value.ToString());

            //Build each location into an object based on the values of each row corresponding to the header's index
            //Skip 1 to ignore headers
            foreach (var row in rows.Skip(1))
            {
                List<Cell> cells = row.ToList();
                Building building = new Building()
                {
                    Rank = (double)cells[GetHeaderIndex(headers, "rank")].Value,
                    Name = (String)cells[GetHeaderIndex(headers, "name")].Value,
                    Coordinate_X = (double)cells[GetHeaderIndex(headers, "x")].Value,
                    Coordinate_Y = (double)cells[GetHeaderIndex(headers, "y")].Value,
                    Elevation = (double)(cells[GetHeaderIndex(headers, "elevation")].Value),
                    Height = (double)(cells[GetHeaderIndex(headers, "height")].Value),
                    Floors = (double)(cells[GetHeaderIndex(headers, "floors")].Value),
                    Year = (double)(cells[GetHeaderIndex(headers, "year")].Value),
                    Notes = (String)(cells[GetHeaderIndex(headers, "notes")].Value)
                };
                buildings.Add(building);
            }
            return buildings;
        }

        /// <summary>
        /// Converts an excelsheet at the given filePath into a List of type Location
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        private List<Location> ExcelSheetToLocations(string filePath)
        {
            //Load up the workbook data}
            WorkBook wb = WorkBook.LoadCSV(filePath);
            WorkSheet ws = wb.DefaultWorkSheet;
            var rows = ws.Rows;

            List<Location> locations = new List<Location>();
            List<String> headers = new List<String>();

            // Get Excel Sheet Headers For Indexing
            foreach (Cell cell in rows.First().ToList()) headers.Add(cell.Value.ToString());

            //Build each location into an object based on the values of each row corresponding to the header's index
            //Skip 1 to ignore headers
            foreach (var row in rows.Skip(1))
            {
                List<Cell> cells = row.ToList();
                Location location = new Location()
                {
                    Name = (String)cells[GetHeaderIndex(headers, "name")].Value,
                    Coordinate_X = (double)cells[GetHeaderIndex(headers, "x")].Value,
                    Coordinate_Y = (double)cells[GetHeaderIndex(headers, "y")].Value,
                    Elevation = (double)(cells[GetHeaderIndex(headers, "elevation")].Value)
                };
                locations.Add(location);
            }
            return locations;
        }
        
        /// <summary>
        /// Given a list of strings, find the index of the provided value
        /// </summary>
        /// <param name="headers"></param>
        /// <param name="header"></param>
        private int GetHeaderIndex(List<string> headers, string header)
        {
            var index = headers.FindIndex(h => h.Equals(header, StringComparison.OrdinalIgnoreCase));
            if (index == -1)
            {
                throw new Exception($"Header '{header}' not found.");
            }
            return index;
        }

        private Building GetNearestBuilding(List<Building> buildingList, Location query)
        {
            Building result = buildingList[0];
            double? MinDistance = null;
            foreach(Building building in buildingList)
            {
                double distance = building.calculateDistance(query, calculate3dCheckbox.Checked);
                if (MinDistance == null ||distance < MinDistance)
                {
                    result = building;
                    MinDistance = distance;
                }
            }

            return result;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}