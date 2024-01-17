using System;
using System.Collections.Generic;
using System.Data;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Orchestrator.Client.Models;
using UiPath.CodedWorkflows.DescriptorIntegration;

namespace ApplicationTrackingProject1
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        public CodedWorkflow()
        {
            _ = new System.Type[]{typeof(UiPath.Core.Activities.API.ISystemService)};
        }

        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>(); }
    }
}

namespace ApplicationTrackingProject1.ObjectRepository
{
    public static class Descriptors
    {
        public static class Calculator
        {
            public static ApplicationTrackingProject1._Implementation._Calculator.__Calculator Calculator { get; private set; } = new ApplicationTrackingProject1._Implementation._Calculator.__Calculator();
        }

        public static class GitExtensions
        {
            public static ApplicationTrackingProject1._Implementation._GitExtensions.__Backstage Backstage { get; private set; } = new ApplicationTrackingProject1._Implementation._GitExtensions.__Backstage();
            public static ApplicationTrackingProject1._Implementation._GitExtensions.__Commit_Screen Commit_Screen { get; private set; } = new ApplicationTrackingProject1._Implementation._GitExtensions.__Commit_Screen();
            public static ApplicationTrackingProject1._Implementation._GitExtensions.__In_Repo In_Repo { get; private set; } = new ApplicationTrackingProject1._Implementation._GitExtensions.__In_Repo();
        }

        public static class Microsoft_Edge
        {
            public static ApplicationTrackingProject1._Implementation._Microsoft_Edge.__Oxigen_Tour_Landing_Page Oxigen_Tour_Landing_Page { get; private set; } = new ApplicationTrackingProject1._Implementation._Microsoft_Edge.__Oxigen_Tour_Landing_Page();
        }

        public static class Notepad__
        {
            public static ApplicationTrackingProject1._Implementation._Notepad__.__Notepad__ Notepad__ { get; private set; } = new ApplicationTrackingProject1._Implementation._Notepad__.__Notepad__();
        }

        public static class Outlook
        {
            public static ApplicationTrackingProject1._Implementation._Outlook.__Outlook_Main_screen Outlook_Main_screen { get; private set; } = new ApplicationTrackingProject1._Implementation._Outlook.__Outlook_Main_screen();
        }
    }
}

namespace ApplicationTrackingProject1._Implementation
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

    namespace _Calculator._Calculator
    {
        public class ___0 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___0(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/b3IATjepQUufbiDam8v0Nw", DisplayName = "0", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___1 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___1(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/Om7M8F_-e0SSTZAed7_VZQ", DisplayName = "1", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___2 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___2(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/EsYPrMoqeEqhkQ-gf2BPIg", DisplayName = "2", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___3 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___3(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/UM3LJMAmOkaow66DTH1IiQ", DisplayName = "3", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___4 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___4(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/xyq50LTZ2UyzwApUQ-e0ug", DisplayName = "4", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___5 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___5(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/aN-swWgJBESdAVdUSGR3Ww", DisplayName = "5", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___6 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___6(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/E-r2DfsL-0yK_W9ttaoaWA", DisplayName = "6", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___7 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___7(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/ZdfG9Cwbv0SQb-cdZ-nCbg", DisplayName = "7", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___8 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___8(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/9ZAcxJfDOEWA_og4K3Ou1w", DisplayName = "8", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator._Calculator
    {
        public class ___9 : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___9(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/yT4hN1pM3UiHnaMUR13t6Q", DisplayName = "9", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Calculator
    {
        public class __Calculator : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Calculator()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/2bEWPSqWLU2fkmSeE7zDOA", DisplayName = "Calculator", Screen = this};
                _0 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___0(this, null);
                _1 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___1(this, null);
                _2 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___2(this, null);
                _3 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___3(this, null);
                _4 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___4(this, null);
                _5 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___5(this, null);
                _6 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___6(this, null);
                _7 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___7(this, null);
                _8 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___8(this, null);
                _9 = new ApplicationTrackingProject1._Implementation._Calculator._Calculator.___9(this, null);
            }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___0 _0 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___1 _1 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___2 _2 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___3 _3 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___4 _4 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___5 _5 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___6 _6 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___7 _7 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___8 _8 { get; private set; }

            public ApplicationTrackingProject1._Implementation._Calculator._Calculator.___9 _9 { get; private set; }
        }
    }

    namespace _GitExtensions._Backstage
    {
        public class __Clone_GitHub_repository : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Clone_GitHub_repository(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/zl4I6h_g3kiJBZt70guwzw", DisplayName = "Clone GitHub repository", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions._Backstage
    {
        public class __Create_new_repository : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Create_new_repository(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/a9GC8xjpzEWhjzGU-heXcQ", DisplayName = "Create new repository", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions._Backstage
    {
        public class __Open_repository : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Open_repository(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/CApTGhpt-E6u1aKx8CkliQ", DisplayName = "Open repository", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions._Backstage
    {
        public class __Studio_Repo_in_Recents : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Studio_Repo_in_Recents(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/DYKyEzv79EmBa4dw9T818A", DisplayName = "Studio Repo in Recents", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions
    {
        public class __Backstage : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Backstage()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/rYYDkW3zA0-tFAWsR5iyyw", DisplayName = "Backstage", Screen = this};
                Clone_GitHub_repository = new ApplicationTrackingProject1._Implementation._GitExtensions._Backstage.__Clone_GitHub_repository(this, null);
                Create_new_repository = new ApplicationTrackingProject1._Implementation._GitExtensions._Backstage.__Create_new_repository(this, null);
                Open_repository = new ApplicationTrackingProject1._Implementation._GitExtensions._Backstage.__Open_repository(this, null);
                Studio_Repo_in_Recents = new ApplicationTrackingProject1._Implementation._GitExtensions._Backstage.__Studio_Repo_in_Recents(this, null);
            }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Backstage.__Clone_GitHub_repository Clone_GitHub_repository { get; private set; }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Backstage.__Create_new_repository Create_new_repository { get; private set; }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Backstage.__Open_repository Open_repository { get; private set; }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Backstage.__Studio_Repo_in_Recents Studio_Repo_in_Recents { get; private set; }
        }
    }

    namespace _GitExtensions._Commit_Screen
    {
        public class ___Commit : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Commit(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/w7fMk6LqkkqAUAZQMTVcsQ", DisplayName = "&Commit", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions._Commit_Screen
    {
        public class ___Reset_all_changes : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public ___Reset_all_changes(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/Xx4DDLLeDUy6lAanOHbq4g", DisplayName = "&Reset all changes", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions._Commit_Screen
    {
        public class __Commit_____push : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Commit_____push(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/iY0BhiypdkOIZnx0J7B3ZA", DisplayName = "Commit && &push", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions._Commit_Screen
    {
        public class __Commit_message : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Commit_message(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/cuk9Q-Ud_027qt-JlC9nFw", DisplayName = "Commit message", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions._Commit_Screen
    {
        public class __Reset_u_nstaged_changes : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Reset_u_nstaged_changes(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/LQ2F_AtGPUOPlTiRwo9-6Q", DisplayName = "Reset u&nstaged changes", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions
    {
        public class __Commit_Screen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Commit_Screen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/649Md6q9b0yrPHN9xolwGA", DisplayName = "Commit Screen", Screen = this};
                _Commit = new ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.___Commit(this, null);
                _Reset_all_changes = new ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.___Reset_all_changes(this, null);
                Commit_____push = new ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.__Commit_____push(this, null);
                Commit_message = new ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.__Commit_message(this, null);
                Reset_u_nstaged_changes = new ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.__Reset_u_nstaged_changes(this, null);
            }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.___Commit _Commit { get; private set; }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.___Reset_all_changes _Reset_all_changes { get; private set; }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.__Commit_____push Commit_____push { get; private set; }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.__Commit_message Commit_message { get; private set; }

            public ApplicationTrackingProject1._Implementation._GitExtensions._Commit_Screen.__Reset_u_nstaged_changes Reset_u_nstaged_changes { get; private set; }
        }
    }

    namespace _GitExtensions._In_Repo
    {
        public class __Branches : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Branches(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/nOk_mSEzOkOSuBO185eLag", DisplayName = "Branches", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _GitExtensions
    {
        public class __In_Repo : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __In_Repo()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/1U2JXftddEy6oWEQrvBtew", DisplayName = "In Repo", Screen = this};
                Branches = new ApplicationTrackingProject1._Implementation._GitExtensions._In_Repo.__Branches(this, null);
            }

            public ApplicationTrackingProject1._Implementation._GitExtensions._In_Repo.__Branches Branches { get; private set; }
        }
    }

    namespace _Microsoft_Edge._Oxigen_Tour_Landing_Page
    {
        public class __Badge : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Badge(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/b91tpOWAFUS0IvVGsiK6kg", DisplayName = "Badge", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Microsoft_Edge._Oxigen_Tour_Landing_Page
    {
        public class __Contact : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Contact(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/KIBSMWdrS02QzrIc2Zg93A", DisplayName = "Contact", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Microsoft_Edge._Oxigen_Tour_Landing_Page
    {
        public class __Contact_Info : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Contact_Info(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/9sZZPKIGmECw8hIPTGK2tA", DisplayName = "Contact Info", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Microsoft_Edge
    {
        public class __Oxigen_Tour_Landing_Page : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Oxigen_Tour_Landing_Page()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/7z84Z8DqoUGhsaHs8BZAyQ", DisplayName = "Oxigen Tour Landing Page", Screen = this};
                Badge = new ApplicationTrackingProject1._Implementation._Microsoft_Edge._Oxigen_Tour_Landing_Page.__Badge(this, null);
                Contact = new ApplicationTrackingProject1._Implementation._Microsoft_Edge._Oxigen_Tour_Landing_Page.__Contact(this, null);
                Contact_Info = new ApplicationTrackingProject1._Implementation._Microsoft_Edge._Oxigen_Tour_Landing_Page.__Contact_Info(this, null);
            }

            public ApplicationTrackingProject1._Implementation._Microsoft_Edge._Oxigen_Tour_Landing_Page.__Badge Badge { get; private set; }

            public ApplicationTrackingProject1._Implementation._Microsoft_Edge._Oxigen_Tour_Landing_Page.__Contact Contact { get; private set; }

            public ApplicationTrackingProject1._Implementation._Microsoft_Edge._Oxigen_Tour_Landing_Page.__Contact_Info Contact_Info { get; private set; }
        }
    }

    namespace _Notepad__
    {
        public class __Notepad__ : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Notepad__()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/c2krzxc4okWK0ac4r-bQcw", DisplayName = "Notepad++", Screen = this};
            }
        }
    }

    namespace _Outlook._Outlook_Main_screen
    {
        public class __Help : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Help(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/zbd1c0gN7UyGiYi1go34zQ", DisplayName = "Help", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Outlook._Outlook_Main_screen
    {
        public class __New_Email : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __New_Email(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/PcJwkj16Zket5JiHuZEWXQ", DisplayName = "New Email", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Outlook._Outlook_Main_screen
    {
        public class __Send___Receive : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Send___Receive(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/XedK5LMfNEu9-ymdHCxOdQ", DisplayName = "Send / Receive", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Outlook._Outlook_Main_screen
    {
        public class __Sent_Items : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __Sent_Items(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/d881lBYaLk6tXn2SaI79bw", DisplayName = "Sent Items", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Outlook._Outlook_Main_screen
    {
        public class __View : IElementDescriptor
        {
            private readonly IScreenDescriptor _screenDescriptor;
            private readonly IElementDescriptor _parentElementDescriptor;
            private readonly IElementDescriptorDefinition _elementDescriptor;
            public IElementDescriptorDefinition GetDefinition()
            {
                return _elementDescriptor;
            }

            public __View(IScreenDescriptor screenDescriptor, IElementDescriptor parentElementDescriptor)
            {
                _screenDescriptor = screenDescriptor;
                _parentElementDescriptor = parentElementDescriptor;
                _elementDescriptor = new ElementDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/eIksCzJzC0icwDsfHgLfeA", DisplayName = "View", Element = this, ParentElement = _parentElementDescriptor, Screen = screenDescriptor};
            }
        }
    }

    namespace _Outlook
    {
        public class __Outlook_Main_screen : IScreenDescriptor
        {
            public IScreenDescriptorDefinition GetDefinition()
            {
                return _screenDescriptor;
            }

            private readonly ScreenDescriptorDefinition _screenDescriptor;
            public __Outlook_Main_screen()
            {
                _screenDescriptor = new ScreenDescriptorDefinition{Reference = "vwUPEdMgN0auIPSHqI6vTg/EA5qeXJcTUyw9x56oARk0Q", DisplayName = "Outlook Main screen", Screen = this};
                Help = new ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__Help(this, null);
                New_Email = new ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__New_Email(this, null);
                Send___Receive = new ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__Send___Receive(this, null);
                Sent_Items = new ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__Sent_Items(this, null);
                View = new ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__View(this, null);
            }

            public ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__Help Help { get; private set; }

            public ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__New_Email New_Email { get; private set; }

            public ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__Send___Receive Send___Receive { get; private set; }

            public ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__Sent_Items Sent_Items { get; private set; }

            public ApplicationTrackingProject1._Implementation._Outlook._Outlook_Main_screen.__View View { get; private set; }
        }
    }
}