using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Text;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting;
using Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass()]
    public class SqlServerUnitTest1 : SqlDatabaseTestClass
    {

        public SqlServerUnitTest1()
        {
            InitializeComponent();
        }

        [TestInitialize()]
        public void TestInitialize()
        {
            base.InitializeTest();
        }
        [TestCleanup()]
        public void TestCleanup()
        {
            base.CleanupTest();
        }

        #region Designer support code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DemoVCom_AdvisorIndexDataGetTest_TestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DemoVCom_AdvisorIndexDataGetTest_PretestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction DemoVCom_AdvisorIndexDataGetTest_PosttestAction;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition rowCountCondition1;
            Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition expectedSchemaCondition1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SqlServerUnitTest1));
            this.DemoVCom_AdvisorIndexDataGetTestData = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestActions();
            DemoVCom_AdvisorIndexDataGetTest_TestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DemoVCom_AdvisorIndexDataGetTest_PretestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            DemoVCom_AdvisorIndexDataGetTest_PosttestAction = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.SqlDatabaseTestAction();
            rowCountCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.RowCountCondition();
            expectedSchemaCondition1 = new Microsoft.Data.Tools.Schema.Sql.UnitTesting.Conditions.ExpectedSchemaCondition();
            // 
            // DemoVCom_AdvisorIndexDataGetTest_TestAction
            // 
            DemoVCom_AdvisorIndexDataGetTest_TestAction.Conditions.Add(rowCountCondition1);
            DemoVCom_AdvisorIndexDataGetTest_TestAction.Conditions.Add(expectedSchemaCondition1);
            resources.ApplyResources(DemoVCom_AdvisorIndexDataGetTest_TestAction, "DemoVCom_AdvisorIndexDataGetTest_TestAction");
            // 
            // DemoVCom_AdvisorIndexDataGetTestData
            // 
            this.DemoVCom_AdvisorIndexDataGetTestData.PosttestAction = DemoVCom_AdvisorIndexDataGetTest_PosttestAction;
            this.DemoVCom_AdvisorIndexDataGetTestData.PretestAction = DemoVCom_AdvisorIndexDataGetTest_PretestAction;
            this.DemoVCom_AdvisorIndexDataGetTestData.TestAction = DemoVCom_AdvisorIndexDataGetTest_TestAction;
            // 
            // DemoVCom_AdvisorIndexDataGetTest_PretestAction
            // 
            resources.ApplyResources(DemoVCom_AdvisorIndexDataGetTest_PretestAction, "DemoVCom_AdvisorIndexDataGetTest_PretestAction");
            // 
            // DemoVCom_AdvisorIndexDataGetTest_PosttestAction
            // 
            resources.ApplyResources(DemoVCom_AdvisorIndexDataGetTest_PosttestAction, "DemoVCom_AdvisorIndexDataGetTest_PosttestAction");
            // 
            // rowCountCondition1
            // 
            rowCountCondition1.Enabled = true;
            rowCountCondition1.Name = "rowCountCondition1";
            rowCountCondition1.ResultSet = 1;
            rowCountCondition1.RowCount = 2;
            // 
            // expectedSchemaCondition1
            // 
            expectedSchemaCondition1.Enabled = true;
            expectedSchemaCondition1.Name = "expectedSchemaCondition1";
            resources.ApplyResources(expectedSchemaCondition1, "expectedSchemaCondition1");
            expectedSchemaCondition1.Verbose = false;
        }

        #endregion


        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        #endregion

        [TestMethod()]
        public void DemoVCom_AdvisorIndexDataGetTest()
        {
            SqlDatabaseTestActions testActions = this.DemoVCom_AdvisorIndexDataGetTestData;
            // Execute the pre-test script
            // 
            System.Diagnostics.Trace.WriteLineIf((testActions.PretestAction != null), "Executing pre-test script...");
            SqlExecutionResult[] pretestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PretestAction);
            try
            {
                // Execute the test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.TestAction != null), "Executing test script...");
                SqlExecutionResult[] testResults = TestService.Execute(this.ExecutionContext, this.PrivilegedContext, testActions.TestAction);
            }
            finally
            {
                // Execute the post-test script
                // 
                System.Diagnostics.Trace.WriteLineIf((testActions.PosttestAction != null), "Executing post-test script...");
                SqlExecutionResult[] posttestResults = TestService.Execute(this.PrivilegedContext, this.PrivilegedContext, testActions.PosttestAction);
            }
        }
        private SqlDatabaseTestActions DemoVCom_AdvisorIndexDataGetTestData;
    }
}
