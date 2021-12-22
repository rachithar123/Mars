using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace MarsQA_1.Pages
{

    public static class NewCertificate
    {


        //Add 
        public static IWebElement Certificatebtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[1]/a[4]"));
        public static IWebElement AddNewbtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/thead/tr/th[4]/div"));
        private static IWebElement CertificateTextBox => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[1]/div/input"));
        private static IWebElement CertifiedFromTextBox => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[1]/input"));
        private static IWebElement YearDropdown => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[2]/div[2]/select"));
        public static IWebElement AddBtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[1]"));
        public static IWebElement AddCancelbtn => Driver.driver.FindElement(By.XPath("//*[@id='account - profile - section']/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/div/div[3]/input[2]"));
     

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //Update

        public static IWebElement UpdateIconbtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[4]/span[1]/i"));
        private static IWebElement UpdateCertificateTextBox => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[1]/input"));
        private static IWebElement UpdateCertificateFromTextBox => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[2]/input"));
        private static IWebElement UpdateYearDd => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/div/div[3]/select"));
        public static IWebElement Updatebtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td/div/span/input[1]"));
        public static IWebElement UpdateCancelbtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td/div/span/input[2]"));

        public static IWebElement findRecordCreated => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[last()]/tr/td[1]"));

                                                                                      
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

        //Delete
        public static IWebElement DeleteBtn => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr/td[4]/span[2]/i"));
        private static IWebElement findEditedRecord => Driver.driver.FindElement(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[5]/div[1]/div[2]/div/table/tbody[2]/tr[last()]/td[1]"));


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//
         
       
         public static void AddStep()
   
         {
                 ExcelLibHelper.PopulateInCollection(@"C:\Users\Rachitha\Desktop\IC\onboarding.specflow-master (1)\MarsQA-1\SpecflowTests\Data\CertificateInfo.xlsx", "Certificate");
                                                  
                 AddNewbtn.Click();

                 Driver.TurnOnWait();

                 CertificateTextBox.SendKeys(ExcelLibHelper.ReadData(2,"Certificate"));

                 CertifiedFromTextBox.SendKeys(ExcelLibHelper.ReadData(2,"From"));

                 YearDropdown.SendKeys(ExcelLibHelper.ReadData(2,"Year"));

                 AddBtn.Click();

         }
        

            public static void AddDataValidate()
             { 
                var wait=new WebDriverWait(Driver.driver,new TimeSpan(0,0,20));

                IWebElement MessageBox = Driver.driver.FindElement(By.ClassName("ns-box-inner")); 

                Assert.That(MessageBox.Text == "ISTQB Foundatation Level has been added to your certification", "Actual Message an Expected Year Message do not match.");
                
            
              } 

        

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

       
           public static void UpdateStep()
            {

             if (findRecordCreated.Text == "ISTQB Foundatation Level")
                {
                    //Driver.TurnOnWait();

                    UpdateIconbtn.Click();

                    UpdateCertificateTextBox.Clear();

                    UpdateCertificateTextBox.SendKeys("MathsComCertified");

                    Updatebtn.Click();

                }
            }
               
            public static void ValidateUpdateData()
            {
            

                 var wait = new WebDriverWait(Driver.driver, new TimeSpan(0, 0, 20));

                 IWebElement UpdatedMessageBox = Driver.driver.FindElement(By.ClassName("ns-box-inner"));
            
                 Assert.That(UpdatedMessageBox.Text == "MathsComCertified has been updated to your certification", "ActualUpdatedMessage an Expected Message do not match");
            }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//     



         public static void DeleteStep()
           {
               if (findEditedRecord.Text == "MathsComCertified")
               {
                   DeleteBtn.Click();
               }
              
           }

               public static void ValidateDeletedData()
                {
                     var wait=new WebDriverWait(Driver.driver,new TimeSpan(0,0,10));

                     IWebElement DeletedMessage = Driver.driver.FindElement(By.ClassName("ns-box-inner"));

                     Assert.That(DeletedMessage.Text == "MathsComCertified has been deleted from your certification", "Certificate record hasn't been deleted");

                }
    }

}



