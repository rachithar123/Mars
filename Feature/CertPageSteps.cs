using MarsQA_1.Pages;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MarsQA_1.Feature
{
    [Binding]
    public class CertPageSteps
    {
        [Given(@"The sellers' is in the Certification page")]
        public void GivenTheSellersIsInTheCertificationPage()
        {
            
            NewCertificate.Certificatebtn.Click();
        }
        
        [When(@"The sellers' click AddNew Button And Enter details")]
        public void WhenTheSellersClickAddNewButtonAndEnterDetails()
        {
           NewCertificate.AddStep();
        }
        
        [When(@"The sellers' click Update button and Edit details")]
        public void WhenTheSellersClickUpdateButtonAndEditDetails()
        {
           NewCertificate.UpdateStep();
        }
        
        [When(@"The sellers' click the Delete button")]
        public void WhenTheSellersClickTheDeleteButton()
        {
            NewCertificate.DeleteStep();
            
        }
        
        [When(@"The sellers' is click  AddNew button and Enter same details")]
        public void WhenTheSellersIsClickAddNewButtonAndEnterSameDetails()
        {
            
        }
        
        [When(@"The sellers' click AddNew button and keep blank details")]
        public void WhenTheSellersClickAddNewButtonAndKeepBlankDetails()
        {
            
        }

        [Then(@"The sellers' able to view  Certificate Successfully Added")]
        public void ThenTheSellersAbleToViewCertificateSuccessfullyAdded()
        {
            
          //NewCertificate.AddDataValidate();
        }

        [Then(@"The sellers' able to see Certificate Updated Successfully")]
        public void ThenTheSellersAbleToSeeCertificateUpdatedSuccessfully()
        {
           //NewCertificate.ValidateUpdateData();
           
        }

        [Then(@"The message should be Certificate Deleted Successfully")]
        public void ThenTheMessageShouldBeCertificateDeletedSuccessfully()
        {
           // NewCertificate.ValidateDeletedData();
          
        }

        [Then(@"The message should appear  Duplicate data")]
        public void ThenTheMessageShouldAppearDuplicateData()
        {
            
        }

        [Then(@"The message should display Please enter Certificates and Certifieds")]
        public void ThenTheMessageShouldDisplayPleaseEnterCertificatesAndCertifieds()
        {
            
        }

    }
}
