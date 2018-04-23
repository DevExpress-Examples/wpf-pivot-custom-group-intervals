using System.Data;
using System.Data.OleDb;
using System.Windows;
using DevExpress.Xpf.PivotGrid;
using HowToBindToMDB.NwindDataSetTableAdapters;
using System;

namespace HowToBindToMDB {
    public partial class MainWindow : Window {
        NwindDataSet.SalesPersonDataTable salesPersonDataTable = 
            new NwindDataSet.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = 
            new SalesPersonTableAdapter();

        public MainWindow() {
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
            pivotGridControl1.CollapseAllRows();
        }

        private void pivotGridControl1_CustomGroupInterval(object sender, 
                PivotCustomGroupIntervalEventArgs e) {
            if(!object.ReferenceEquals(e.Field, fieldProductGroup)) return;
            string productName = Convert.ToString(e.Value);
            if(productName[0] < 'F')
                e.GroupValue = "A-E";
            else if(productName[0] > 'E' && productName[0] < 'T')
                e.GroupValue = "F-S";
            else if(productName[0] > 'S')
                e.GroupValue = "T-Z";
        }
    }
}
