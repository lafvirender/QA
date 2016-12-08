using LAFTestAutomationFramework.Helpers;
using LAFTestAutomationFramework.ApplicationBasedHelpers;
namespace LAFTestAutomationFramework.Funnel.AgentProposalForSell.Slides
{
    public class Languages
    {

        private readonly TestObject _languagesSlide;

        private readonly TestObject _arabic;
        private readonly TestObject _cantonese;
        private readonly TestObject _croatian;
        private readonly TestObject _dutch;
        private readonly TestObject _french;
        private readonly TestObject _greek;
        private readonly TestObject _hebrew;
        private readonly TestObject _hindi;
        private readonly TestObject _hungarian;
        private readonly TestObject _indonesian;
        private readonly TestObject _english;
        private readonly TestObject _italian;
        private readonly TestObject _japanese;
        private readonly TestObject _korean;
        private readonly TestObject _lebanese;
        private readonly TestObject _macedonian;
        private readonly TestObject _maltese;
        private readonly TestObject _mandarin;
        private readonly TestObject _persian;
        private readonly TestObject _polish;
        private readonly TestObject _portuguese;
        private readonly TestObject _russian;
        private readonly TestObject _serbian;
        private readonly TestObject _spanish;
        private readonly TestObject _sriLankan;
        private readonly TestObject _tagalog;
        private readonly TestObject _thai;
        private readonly TestObject _turkish;
        private readonly TestObject _vietnamese;

        private readonly TestObject _languageSelectionQ;
        private readonly TestObject _next;

        public Languages(Browser browser, TestObjectProperties eltLanguagesSlide,
         TestObjectProperties btnArabic, TestObjectProperties btnCantonese,
         TestObjectProperties btnCroatian, TestObjectProperties btnDutch,
         TestObjectProperties btnFrench, TestObjectProperties btnGreek,
         TestObjectProperties btnHebrew, TestObjectProperties btnHindi,
         TestObjectProperties btnHungarian, TestObjectProperties btnIndonesian,
         TestObjectProperties btnEnglish, TestObjectProperties btnItalian,
         TestObjectProperties btnJapanese, TestObjectProperties btnKorean,
         TestObjectProperties btnLebanese, TestObjectProperties btnMacedonian,
         TestObjectProperties btnMaltese, TestObjectProperties btnMandarin,
         TestObjectProperties btnPersian, TestObjectProperties btnPolish,
         TestObjectProperties btnPortuguese, TestObjectProperties btnRussian,
         TestObjectProperties btnSerbian, TestObjectProperties btnSpanish,
         TestObjectProperties btnSriLankan, TestObjectProperties btnTagalog,
         TestObjectProperties btnThai, TestObjectProperties btnTurkish,
         TestObjectProperties btnVietnamese, TestObjectProperties btnNext,
         TestObjectProperties eltLanguageSelectionQuestion)
        {
            _languagesSlide = new TestObject(browser, eltLanguagesSlide);
            _arabic = new TestObject(browser, btnArabic);
            _cantonese = new TestObject(browser, btnCantonese);
            _croatian = new TestObject(browser, btnCroatian);
            _dutch = new TestObject(browser, btnDutch);
            _french = new TestObject(browser, btnFrench);
            _greek = new TestObject(browser, btnGreek);
            _hebrew = new TestObject(browser, btnHebrew);
            _hindi = new TestObject(browser, btnHindi);
            _hungarian = new TestObject(browser, btnHungarian);
            _indonesian = new TestObject(browser, btnIndonesian);
            _english = new TestObject(browser, btnEnglish);
            _italian = new TestObject(browser, btnItalian);
            _japanese = new TestObject(browser, btnJapanese);
            _korean = new TestObject(browser, btnKorean);
            _lebanese = new TestObject(browser, btnLebanese);
            _macedonian = new TestObject(browser, btnMacedonian);
            _maltese = new TestObject(browser, btnMaltese);
            _mandarin = new TestObject(browser, btnMandarin);
            _persian = new TestObject(browser, btnPersian);
            _polish = new TestObject(browser, btnPolish);
            _portuguese = new TestObject(browser, btnPortuguese);
            _russian = new TestObject(browser, btnRussian);
            _serbian = new TestObject(browser, btnSerbian);
            _spanish = new TestObject(browser, btnSpanish);
            _sriLankan = new TestObject(browser, btnSriLankan);
            _tagalog = new TestObject(browser, btnTagalog);
            _thai = new TestObject(browser, btnThai);
            _turkish = new TestObject(browser, btnTurkish);
            _vietnamese = new TestObject(browser, btnVietnamese);
            _next = new TestObject(browser, btnNext);
            _languageSelectionQ = new TestObject(browser, eltLanguageSelectionQuestion);
        }

        public VerificationInfo ShouldVerifyTheQuestionWith(string text)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = text;
            info.Actual = GetQuestionText();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        private string GetQuestionText()
        {
            return _languageSelectionQ.GetText();
        }

        public VerificationInfo IsDisplayed()
        {
            return _languagesSlide.VerifyDisplayStyleWith("block");
        }

        public void SelectArabic()
        {
            _arabic.Click();
        }

        public void SelectCatonese()
        {
            _cantonese.Click();
        }

        public void SelectCroatian()
        {
            _croatian.Click();
        }

        public void SelectDutch()
        {
            _dutch.Click();
        }

        public void SelectFrench()
        {
            _french.Click();
        }

        public void SelectGreek()
        {
            _greek.Click();
        }

        public void SelectHebrew()
        {
            _hebrew.Click();
        }

        public void SelectHindi()
        {
            _hindi.Click();
        }

        public void SelectHungarian()
        {
            _hungarian.Click();
        }

        public void SelectIndonesian()
        {
            _indonesian.Click();
        }

        public void SelectEnglish()
        {
            if (ShouldVerifyTheColorOfLanguageOptionEnglishWith("#00AEFF").Result)
                _english.Click();    
        }

        public void SelectItalian()
        {
            _italian.Click();
        }

        public void SelectJapanese()
        {
            _japanese.Click();
        }

        public void SelectKorean()
        {
            _korean.Click();
        }

        public void SelectLabanese()
        {
            _lebanese.Click();
        }

        public void SelectMacedonian()
        {
            _macedonian.Click();
        }

        public void SelectMaltese()
        {
           _maltese.Click();
        }

        public void SelectMandarin()
        {
            _mandarin.Click();
        }

        public void SelectPersian()
        {
            _persian.Click();
        }

        public void SelectPolish()
        {
            _polish.Click();
        }
        public void SelectPortuguese()
        {
            _portuguese.Click();
        }

        public void SelectRussian()
        {
            _russian.Click();
        }

        public void SelectSerbian()
        {
            _serbian.Click();
        }

        public void SelectSpanish()
        {
            _spanish.Click();
        }

        public void SelectSrilankan()
        {
            _sriLankan.Click();
        }

        public void SelectTagalog()
        {
            _tagalog.Click();
        }

        public void SelectThai()
        {
            _thai.Click();
        }

        public void SelectTurkish()
        {
            _turkish.Click();
        }

        public void SelectVietnamese()
        {
            _vietnamese.Click();
        }

        public void ClickNext()
        {
            _next.Click();
        }

        public void SelectLanguagesAs(string alllanguages)
        {
            var languages = alllanguages.Split(',');
            foreach (var language in languages)
            {
                var option = (LanguagesEnum) System.Enum.Parse(typeof(LanguagesEnum), language);

                switch (option)
                {
                    case LanguagesEnum.Arabic:
                        SelectArabic();
                        break;

                    case LanguagesEnum.Cantonese:
                        SelectCatonese();
                        break;

                    case LanguagesEnum.Croatian:
                       SelectCroatian();
                        break;

                    case LanguagesEnum.Dutch:
                        SelectDutch();
                        break;

                    case LanguagesEnum.English:
                        SelectEnglish();
                        break;

                    case LanguagesEnum.French:
                        SelectFrench();
                        break;

                    case  LanguagesEnum.Greek:
                        SelectGreek();
                        break;

                    case LanguagesEnum.Hebrew:
                        SelectHebrew();
                        break;

                    case  LanguagesEnum.Hindi:
                        SelectHindi();
                        break;

                    case  LanguagesEnum.Hungarian:
                        SelectHungarian();
                        break;

                    case LanguagesEnum.Indonesian:
                        SelectIndonesian();
                        break;

                    case  LanguagesEnum.Italian:
                        SelectItalian();
                        break;

                    case LanguagesEnum.Japanese:
                        SelectJapanese();
                        break;

                    case LanguagesEnum.Korean:
                        SelectKorean();
                        break;

                    case LanguagesEnum.Lebanese:
                        SelectLabanese();
                        break;

                    case LanguagesEnum.Macedonian:
                        SelectMacedonian();
                        break;

                    case  LanguagesEnum.Maltese:
                        SelectMaltese();
                        break;

                    case LanguagesEnum.Mandarin:
                        SelectMandarin();
                        break;

                    case  LanguagesEnum.Persian:
                        SelectPersian();
                        break;

                    case LanguagesEnum.Polish:
                        SelectPolish();
                        break;

                    case LanguagesEnum.Portuguese:
                        SelectPortuguese();
                        break;
           
                    case LanguagesEnum.Russian:
                        SelectRussian();
                        break;

                    case LanguagesEnum.Serbian:
                        SelectSerbian();
                        break;

                    case LanguagesEnum.Spanish:
                        SelectSpanish();
                        break;
                    
                    case LanguagesEnum.Srilankan:
                        SelectSrilankan();
                        break;

                    case LanguagesEnum.Tagalog:
                        SelectTagalog();
                        break;
                    case LanguagesEnum.Thai:
                        SelectThai();
                        break;

                    case LanguagesEnum.Turkish:
                        SelectTurkish();
                        break;
                    
                    case LanguagesEnum.Vietnamese:
                        SelectVietnamese();
                        break;

                    default:
                        return;
                }
            }
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionArabicWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _arabic.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionCantoneseWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _cantonese.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionCroatianWith(string expectedColorHexValue)
        {

            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _croatian.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionDutchWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _dutch.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionEnglishWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _english.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionFrenchWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _french.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionGreekWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _greek.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionHebrewWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _hebrew.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionHindiWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _hindi.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionHungarianWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _hungarian.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionIndonesianWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _indonesian.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionItalianWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _italian.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionJapaneseWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _japanese.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionKoreanWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _korean.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionLebaneseWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _lebanese.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;

        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionMacedonianWith(string expectedColorHexValue)
        {

            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _macedonian.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionMalteseWith(string expectedColorHexValue)
        {

            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _maltese.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionMandarinWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _mandarin.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionPersianWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _persian.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionPolishWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _polish.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;

        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionPortugueseWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _portuguese.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionRussianWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _russian.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionSerbianWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _serbian.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionSpanishWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _spanish.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionSrilankanWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _sriLankan.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionTagalogWith(string expectedColorHexValue)
        {

            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _tagalog.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionThaiWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _thai.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionTurkishWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _turkish.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }

        public VerificationInfo ShouldVerifyTheColorOfLanguageOptionVietnameseWith(string expectedColorHexValue)
        {
            VerificationInfo info = new VerificationInfo();
            info.Expected = expectedColorHexValue;
            info.Actual = _vietnamese.GetBackgroundColorHexValue();
            if (info.Expected == info.Actual)
                info.Result = true;
            else
                info.Result = false;

            return info;
        }
    }
}
