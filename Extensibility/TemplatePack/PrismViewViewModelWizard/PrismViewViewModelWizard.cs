using Microsoft.VisualStudio.TemplateWizard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnvDTE;

namespace PrismViewViewModelWizard
{
    public class PrismViewViewModelWizard : IWizard
    {
        public void BeforeOpeningFile(ProjectItem projectItem)
        {
        }

        public void ProjectFinishedGenerating(Project project)
        {
        }

        public void ProjectItemFinishedGenerating(ProjectItem projectItem)
        {
        }

        public void RunFinished()
        {
        }

        public void RunStarted(object automationObject, Dictionary<string, string> replacementsDictionary, WizardRunKind runKind, object[] customParams)
        {
            replacementsDictionary.Add("$viewsfolderlocation$", "Views");
            replacementsDictionary.Add("$viewmodelsfolderlocation$", "ViewModels");
        }

        public bool ShouldAddProjectItem(string filePath)
        {
            return true;
        }
    }
}
