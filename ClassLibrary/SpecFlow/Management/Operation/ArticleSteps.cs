using ClassLibrary.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ClassLibrary.SpecFlow.Management.Operation
{
    [Binding]
    public class ArticleSteps
    {
        [Then(@"I select EduSoho on \[DROPDOWNLIST\|CATEGORY] on \[PAGE\|ARTICLE]")]
        public void ThenISelectEduSohoOnDROPDOWNLISTCOLUMNOnPAGEARTICLE()
        {
            Pages.ArticlePage.SelectCategory("EduSoho");
        }

        [Then(@"I click \[BUTTON\|SEARCH] on \[PAGE\|ARTICLE]")]
        public void ThenIClickBUTTONSEARCHOnPAGEARTICLE()
        {
            Pages.ArticlePage.ClickSearch();
        }

        [Then(@"I fill \{WORLD} in \[TEXTBOX\|KEYWORD] on \[PAGE\|ARTICLE]")]
        public void ThenIFillWORLDInTEXTBOXKEYWORDOnPAGEARTICLE()
        {
            Pages.ArticlePage.InputKeyword("世界");
        }

        [Then(@"I clear \[TEXTBOX\|KEYWORD] on \[PAGE\|ARTICLE]")]
        public void ThenIClearTEXTBOXKEYWORDOnPAGEARTICLE()
        {
            Pages.ArticlePage.ClearKeyword();
        }

        [Then(@"I select \{HEADLINE} on \[DROPDOWNLIST\|ATTRIBUTE] on \[PAGE\|ARTICLE]")]
        public void ThenISelectHEADLINEOnDROPDOWNLISTATTRIBUTEOnPAGEARTICLE()
        {
            Pages.ArticlePage.SelectAttribute("头条");
        }

        [Then(@"I select \{PUBLISHED} on \[DROPDOWNLIST\|STATUS] on \[PAGE\|ARTICLE]")]
        public void ThenISelectPUBLISHEDOnDROPDOWNLISTSTATUSOnPAGEARTICLE()
        {
            Pages.ArticlePage.SelectStatus("已发布");
        }

        [Then(@"I click rectangular on \[DROPDOWNLIST\|STATUS] and select a status on \[DROPDOWNLIST\|STATUS] on \[PAGE\|ARTICLE]")]
        public void ThenIClickRectangularOnDROPDOWNLISTSTATUSAndSelectAStatusOnDROPDOWNLISTSTATUSOnPAGEARTICLE()
        {
            Pages.ArticlePage.ChangeStatus(1);
        }

    }
}
