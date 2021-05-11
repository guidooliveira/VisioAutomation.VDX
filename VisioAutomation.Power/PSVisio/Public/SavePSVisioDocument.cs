using System;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using VisioAutomation.Power;

namespace PSVisio
{
    [Cmdlet(VerbsData.Save, "PSVisioDocument")]
    public class SavePSVisioDocument : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        [Alias("VisioDocument","Document")]
        public VisioAutomation.Power.Elements.Drawing InputObject { get; set; }
        
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string FilePath { get; set; }

        private string resolvedPath { get; set; }
        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
            this.resolvedPath = this.GetUnresolvedProviderPathFromPSPath(this.FilePath);
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
  
            this.InputObject.Save(this.resolvedPath);

            //WriteObject(document);
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}