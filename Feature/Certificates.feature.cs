// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:3.1.0.0
//      SpecFlow Generator Version:3.1.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace MarsQA_1.Feature
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.1.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Certificates1")]
    public partial class Certificates1Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Certificates.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Certificates1", "\tAs a Seller\r\n\t\t I want to be able to complete my Certification section of Profil" +
                    "e\r\n\t\t So that anyone can view my updations of Certification", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add New Certificate1 to Profile Details")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AddNewCertificate1ToProfileDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add New Certificate1 to Profile Details", null, new string[] {
                        "mytag"});
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("The Seller is on the Profile details page to Add New Certificate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.When("The Seller enters Certificate,Certificate From", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table1.AddRow(new string[] {
                            "Cloud Practitioner",
                            "",
                            "AWS",
                            "",
                            "2020"});
#line 10
 testRunner.And("select the Year", ((string)(null)), table1, "And ");
#line hidden
#line 13
 testRunner.Then("it should display message \"Cloud Practitioner has been added to your Certificate\"" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Certificate to the Profile details page using Special Characters")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AddCertificateToTheProfileDetailsPageUsingSpecialCharacters()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Certificate to the Profile details page using Special Characters", null, new string[] {
                        "mytag"});
#line 16
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 17
 testRunner.Given("The Seller is on the Profile details page to Add Certificate with Special charact" +
                        "ers", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 18
 testRunner.When("The Seller enter Certificate,Certified From", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table2.AddRow(new string[] {
                            "Cloud Practitioner",
                            "",
                            "AWS",
                            "",
                            "2020"});
                table2.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
#line 19
 testRunner.And("select the Year", ((string)(null)), table2, "And ");
#line hidden
#line 23
 testRunner.Then("it should display message \"$%###@@#$%  has been added to your Certificate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Certificate to the Profile Details paage using nemeric values")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AddCertificateToTheProfileDetailsPaageUsingNemericValues()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Certificate to the Profile Details paage using nemeric values", null, new string[] {
                        "mytag"});
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 27
 testRunner.Given("The Seller is on the Profile details page to Add Certificate with numerical value" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
 testRunner.When("The Seller enter Certificate,Certified From", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table3.AddRow(new string[] {
                            "Cloud Practitioner",
                            "",
                            "AWS",
                            "",
                            "2020"});
                table3.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
                table3.AddRow(new string[] {
                            "12324255",
                            "",
                            "HTTP",
                            "",
                            "1998"});
#line 29
 testRunner.And("select the Year", ((string)(null)), table3, "And ");
#line hidden
#line 34
 testRunner.Then("it should display message \"12324255  has been added to your Certificate\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Exsisting Certificate on Profile Details")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void UpdateExsistingCertificateOnProfileDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Exsisting Certificate on Profile Details", null, new string[] {
                        "mytag"});
#line 37
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table4.AddRow(new string[] {
                            "Cloud Practitioner",
                            "",
                            "AWS",
                            "",
                            "2020"});
                table4.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
                table4.AddRow(new string[] {
                            "12324255",
                            "",
                            "HTTP",
                            "",
                            "1998"});
#line 38
 testRunner.Given("The Seller is on the Profile page to update only Certificates details", ((string)(null)), table4, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table5.AddRow(new string[] {
                            "Solution Architech",
                            "",
                            "AWS",
                            "",
                            "2020"});
                table5.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
                table5.AddRow(new string[] {
                            "12324255",
                            "",
                            "HTTP",
                            "",
                            "1998"});
#line 43
 testRunner.When("The Seller enter Certificate", ((string)(null)), table5, "When ");
#line hidden
#line 48
 testRunner.Then("it should display message \"Solution Architech has been updated in your Profile\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Update Certified From on Profile Details")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void UpdateCertifiedFromOnProfileDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Update Certified From on Profile Details", null, new string[] {
                        "mytag"});
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table6.AddRow(new string[] {
                            "Solution Architech",
                            "",
                            "AWS",
                            "",
                            "2020"});
                table6.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
                table6.AddRow(new string[] {
                            "12324255",
                            "",
                            "HTTP",
                            "",
                            "1998"});
#line 52
 testRunner.Given("The Seller is on the Profile page to update only Certified details", ((string)(null)), table6, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table7.AddRow(new string[] {
                            "Solution Architech",
                            "",
                            "@#$$AWS",
                            "",
                            "2020"});
                table7.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
                table7.AddRow(new string[] {
                            "12324255",
                            "",
                            "HTTP",
                            "",
                            "1998"});
#line 57
 testRunner.When("The Seller enter Certified From", ((string)(null)), table7, "When ");
#line hidden
#line 62
 testRunner.Then("it should display message \"Solution Architech has been updated in your Profile\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Delete Certificate from Profile Details")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void DeleteCertificateFromProfileDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Delete Certificate from Profile Details", null, new string[] {
                        "mytag"});
#line 65
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
                TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table8.AddRow(new string[] {
                            "Solution Architech",
                            "",
                            "@#$$AWS",
                            "",
                            "2000"});
                table8.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
                table8.AddRow(new string[] {
                            "12324255",
                            "",
                            "HTTP",
                            "",
                            "1998"});
#line 66
 testRunner.Given("The Seller is on the Profile page to Delete the Certificate details", ((string)(null)), table8, "Given ");
#line hidden
                TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table9.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
                table9.AddRow(new string[] {
                            "12324255",
                            "",
                            "HTTP",
                            "",
                            "1998"});
#line 71
 testRunner.When("The Seller delete the Certificate", ((string)(null)), table9, "When ");
#line hidden
#line 75
 testRunner.Then("it should display message \"Solution Architech has been deleted from your Profile\"" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Add Same Certificate details to the Profile Details")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void AddSameCertificateDetailsToTheProfileDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add Same Certificate details to the Profile Details", null, new string[] {
                        "mytag"});
#line 78
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 79
 testRunner.Given("The Seller is on Profile details page to Add same Certificate", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table10.AddRow(new string[] {
                            "Solution Architech",
                            "",
                            "@#$$AWS",
                            "",
                            "2000"});
#line 80
 testRunner.When("The Seller enter same Certificate details", ((string)(null)), table10, "When ");
#line hidden
#line 83
 testRunner.Then("it should display the message \"Duplicate data \"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Keeps the blank data feilds on Profile Details")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        public virtual void KeepsTheBlankDataFeildsOnProfileDetails()
        {
            string[] tagsOfScenario = new string[] {
                    "mytag"};
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Keeps the blank data feilds on Profile Details", null, new string[] {
                        "mytag"});
#line 86
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 87
testRunner.Given("The Seller is on Profile details page to keep Certificate feild blank", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
                TechTalk.SpecFlow.Table table11 = new TechTalk.SpecFlow.Table(new string[] {
                            "Certificate or Award",
                            "",
                            "Certified From",
                            "",
                            "Year"});
                table11.AddRow(new string[] {
                            "Solution Architech",
                            "",
                            "@#$$AWS",
                            "",
                            "2000"});
                table11.AddRow(new string[] {
                            "$%###@@#$%",
                            "",
                            "C++",
                            "",
                            "2021"});
                table11.AddRow(new string[] {
                            "12324255",
                            "",
                            "HTTP",
                            "",
                            "1998"});
                table11.AddRow(new string[] {
                            "",
                            "",
                            "MAco",
                            "",
                            "2001"});
#line 88
testRunner.When("The seller keep blank feild", ((string)(null)), table11, "When ");
#line hidden
#line 94
testRunner.Then("it should display the message \"Please enter Certificates and Certifieds\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
