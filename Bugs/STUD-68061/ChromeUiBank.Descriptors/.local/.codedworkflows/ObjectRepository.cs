using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ChromeUiBank.Descriptors.ObjectRepository
{
    public static class Descriptors
    {
        public static class Chrome_UiBank
        {
            static string _reference = "8X17740v6kWiNb-uRaE_bA/A8EAqIsU90Ow3XE4rylQNA";
            public static _Implementation._Chrome_UiBank.__UiBank_Home UiBank_Home { get; private set; } = new _Implementation._Chrome_UiBank.__UiBank_Home();
        }
    }
}

namespace ChromeUiBank.Descriptors._Implementation
{
    internal class ScreenDescriptorDefinition : IScreenDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }
    }

    internal class ElementDescriptorDefinition : IElementDescriptorDefinition
    {
        public IScreenDescriptor Screen { get; set; }

        public string Reference { get; set; }

        public string DisplayName { get; set; }

        public IElementDescriptor ParentElement { get; set; }

        public IElementDescriptor Element { get; set; }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan
    {
        public class __EnterLoanID : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __EnterLoanID(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/vGUp3eAyK0-Ok8s9Tez11A", DisplayName = "EnterLoanID", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __Age : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Age(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/O1xc9SeTXEyV_xGSMD9Hiw", DisplayName = "Age", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __Amount : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Amount(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/wt5U7VnVHESXV29ReFfVIQ", DisplayName = "Amount", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __EmailAddress : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __EmailAddress(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/9LJCq_8e90CZWnt7ncBJow", DisplayName = "EmailAddress", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __Income : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Income(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/ye-PBglreEOf7bYdBz_c-A", DisplayName = "Income", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __LoanID : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LoanID(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/pK9nVFqEm0mqJMsWA8n19g", DisplayName = "LoanID", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __Rate : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Rate(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/gkroqcWoAEmYXbWhJzGjPw", DisplayName = "Rate", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __SorryMessage : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __SorryMessage(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/die0ft8FWU6PWN5ovIXLQA", DisplayName = "SorryMessage", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __Term : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Term(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/D54sIFa9PkW-efMVsLwRoQ", DisplayName = "Term", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails
    {
        public class __YourLoanDetails : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __YourLoanDetails(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/nTeTAxErekGiWM9ZxpAudQ", DisplayName = "YourLoanDetails", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan
    {
        public class __RetrieveLoanDetails : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __RetrieveLoanDetails(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/pfIYy6It20-2uPWi1_ISLw", DisplayName = "RetrieveLoanDetails", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                Age = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Age(screenDescriptor, this);
                Amount = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Amount(screenDescriptor, this);
                EmailAddress = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__EmailAddress(screenDescriptor, this);
                Income = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Income(screenDescriptor, this);
                LoanID = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__LoanID(screenDescriptor, this);
                Rate = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Rate(screenDescriptor, this);
                SorryMessage = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__SorryMessage(screenDescriptor, this);
                Term = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Term(screenDescriptor, this);
                YourLoanDetails = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__YourLoanDetails(screenDescriptor, this);
            }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Age Age { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Amount Amount { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__EmailAddress EmailAddress { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Income Income { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__LoanID LoanID { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Rate Rate { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__SorryMessage SorryMessage { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__Term Term { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan._RetrieveLoanDetails.__YourLoanDetails YourLoanDetails { get; private set; }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_
    {
        public class __AlreadyHaveALoan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __AlreadyHaveALoan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/YRT_F2DE60m-cHeWp4qbcg", DisplayName = "AlreadyHaveALoan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                EnterLoanID = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan.__EnterLoanID(screenDescriptor, this);
                RetrieveLoanDetails = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan.__RetrieveLoanDetails(screenDescriptor, this);
            }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan.__EnterLoanID EnterLoanID { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._AlreadyHaveALoan.__RetrieveLoanDetails RetrieveLoanDetails { get; private set; }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_
    {
        public class __Age : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Age(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/BZWuTAS0bkqJVWZhRO0wfw", DisplayName = "Age", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_
    {
        public class __Email_Address : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Email_Address(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/Hm6iYlvP502ZMo5TsPYTjQ", DisplayName = "Email Address", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_
    {
        public class __Income : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Income(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/A4oNfmzKHEek7TX7FiYIcw", DisplayName = "Income", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_
    {
        public class __Loan_Amount : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Amount(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/KSa1IXMsYk62FRaceabObw", DisplayName = "Loan Amount", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_
    {
        public class __Loan_Term : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Loan_Term(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/9b1YlzUCaEWf3OQ4PyXdTw", DisplayName = "Loan Term", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan
    {
        public class __ApplyForAnotherLoan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __ApplyForAnotherLoan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/fIRlwqXa_EmP3tXy8XbObQ", DisplayName = "ApplyForAnotherLoan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan
    {
        public class __LoanID : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LoanID(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/j6L5JZGpEEKSKuQeBZNkyw", DisplayName = "LoanID", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan
    {
        public class __LoanRate : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LoanRate(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/4MbwAvHd30ChgrA6vhft5A", DisplayName = "LoanRate", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan
    {
        public class __NotApproved : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __NotApproved(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/d94PudfVsEieoQQ9BkKTaA", DisplayName = "NotApproved", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan
    {
        public class __NotApprovedFailMessage : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __NotApprovedFailMessage(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/z_xC5y_Uake38N1Mu0YNZQ", DisplayName = "NotApprovedFailMessage", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_
    {
        public class __Submit_Loan : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Submit_Loan(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/1Xa_eE_Wq0ai2EIRRjdd6Q", DisplayName = "Submit Loan", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                ApplyForAnotherLoan = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__ApplyForAnotherLoan(screenDescriptor, this);
                LoanID = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__LoanID(screenDescriptor, this);
                LoanRate = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__LoanRate(screenDescriptor, this);
                NotApproved = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__NotApproved(screenDescriptor, this);
                NotApprovedFailMessage = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__NotApprovedFailMessage(screenDescriptor, this);
            }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__ApplyForAnotherLoan ApplyForAnotherLoan { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__LoanID LoanID { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__LoanRate LoanRate { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__NotApproved NotApproved { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_._Submit_Loan.__NotApprovedFailMessage NotApprovedFailMessage { get; private set; }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_
    {
        public class __Click__ApplyForALoan_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__ApplyForALoan_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/Zm1O3SfufkKFr73mpnQ18Q", DisplayName = "Click 'ApplyForALoan'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                Age = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Age(screenDescriptor, this);
                Email_Address = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Email_Address(screenDescriptor, this);
                Income = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Income(screenDescriptor, this);
                Loan_Amount = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Loan_Amount(screenDescriptor, this);
                Loan_Term = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Loan_Term(screenDescriptor, this);
                Submit_Loan = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Submit_Loan(screenDescriptor, this);
            }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Age Age { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Email_Address Email_Address { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Income Income { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Loan_Amount Loan_Amount { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Loan_Term Loan_Term { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_._Click__ApplyForALoan_.__Submit_Loan Submit_Loan { get; private set; }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Click__Menu___Products_
    {
        public class __Click__Menu___Loans_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Menu___Loans_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/l8frtfvdbEyA5mkfIug7tA", DisplayName = "Click 'Menu - Loans'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                AlreadyHaveALoan = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_.__AlreadyHaveALoan(screenDescriptor, this);
                Click__ApplyForALoan_ = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_.__Click__ApplyForALoan_(screenDescriptor, this);
            }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_.__AlreadyHaveALoan AlreadyHaveALoan { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_._Click__Menu___Loans_.__Click__ApplyForALoan_ Click__ApplyForALoan_ { get; private set; }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home
    {
        public class __Click__Menu___Products_ : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Click__Menu___Products_(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/snEKh9Tm0UKgZvuj0bhK8A", DisplayName = "Click 'Menu - Products'", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                Click__Menu___Loans_ = new _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_.__Click__Menu___Loans_(screenDescriptor, this);
            }

            public _Implementation._Chrome_UiBank._UiBank_Home._Click__Menu___Products_.__Click__Menu___Loans_ Click__Menu___Loans_ { get; private set; }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home
    {
        public class __LoginFailed : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LoginFailed(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/fNBXK1533ky98sAFRBmxMA", DisplayName = "LoginFailed", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home
    {
        public class __LoginFailedMessage : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __LoginFailedMessage(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/LupaSWqcy0albdmTS0kegw", DisplayName = "LoginFailedMessage", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home
    {
        public class __Logout : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Logout(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/iwi101U4XU2_3LRWROQW0A", DisplayName = "Logout", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home
    {
        public class __Password : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Password(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/Fwjg1X0N-kuq6nP3mVm9nA", DisplayName = "Password", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home._Sign_In
    {
        public class __PolicyAgreement : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __PolicyAgreement(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/olo782Z4lECY_kZysWpwXA", DisplayName = "PolicyAgreement", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home
    {
        public class __Sign_In : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sign_In(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/ye_4b-oQlUe__5jlor0zjw", DisplayName = "Sign In", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
                PolicyAgreement = new _Implementation._Chrome_UiBank._UiBank_Home._Sign_In.__PolicyAgreement(screenDescriptor, this);
            }

            public _Implementation._Chrome_UiBank._UiBank_Home._Sign_In.__PolicyAgreement PolicyAgreement { get; private set; }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home
    {
        public class __UiBankLogo : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __UiBankLogo(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/aDtsdQpt102L9wkAWizv6g", DisplayName = "UiBankLogo", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank._UiBank_Home
    {
        public class __Username : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Username(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/hCD7EgYDdkqz65JNO4LcHw", DisplayName = "Username", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Chrome_UiBank
    {
        public class __UiBank_Home : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __UiBank_Home()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "8X17740v6kWiNb-uRaE_bA/74l5x87y10-6udQarsNcHQ", DisplayName = "UiBank Home", Screen = this};
                Click__Menu___Products_ = new _Implementation._Chrome_UiBank._UiBank_Home.__Click__Menu___Products_(this, null);
                LoginFailed = new _Implementation._Chrome_UiBank._UiBank_Home.__LoginFailed(this, null);
                LoginFailedMessage = new _Implementation._Chrome_UiBank._UiBank_Home.__LoginFailedMessage(this, null);
                Logout = new _Implementation._Chrome_UiBank._UiBank_Home.__Logout(this, null);
                Password = new _Implementation._Chrome_UiBank._UiBank_Home.__Password(this, null);
                Sign_In = new _Implementation._Chrome_UiBank._UiBank_Home.__Sign_In(this, null);
                UiBankLogo = new _Implementation._Chrome_UiBank._UiBank_Home.__UiBankLogo(this, null);
                Username = new _Implementation._Chrome_UiBank._UiBank_Home.__Username(this, null);
            }

            public _Implementation._Chrome_UiBank._UiBank_Home.__Click__Menu___Products_ Click__Menu___Products_ { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home.__LoginFailed LoginFailed { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home.__LoginFailedMessage LoginFailedMessage { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home.__Logout Logout { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home.__Password Password { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home.__Sign_In Sign_In { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home.__UiBankLogo UiBankLogo { get; private set; }

            public _Implementation._Chrome_UiBank._UiBank_Home.__Username Username { get; private set; }
        }
    }
}