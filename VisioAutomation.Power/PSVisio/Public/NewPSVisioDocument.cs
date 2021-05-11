using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using VisioAutomation.Power;

namespace PSVisio
{
    [Cmdlet(VerbsCommon.New, "PSVisioDocument")]
    public class NewPSVisioDocument : PSCmdlet
    {
        //[Parameter(
        //    Mandatory = true,
        //    Position = 0,
        //    ValueFromPipeline = true,
        //    ValueFromPipelineByPropertyName = true)]
        //public int FavoriteNumber { get; set; }

        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            var Template = new VisioAutomation.Power.Template();
            var document = new VisioAutomation.Power.Elements.Drawing(template: Template);
            WriteObject(document);
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}