using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;

namespace PSVisio
{
    [Cmdlet(VerbsCommon.Add, "PSVisioPage")]
    public class AddPSVisioPage : PSCmdlet
    {
        [Parameter(
            Mandatory = true,
            Position = 0,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        [Alias("VisioDocument", "Document")]
        public VisioAutomation.Power.Elements.Drawing InputObject { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 1,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public double Height { get; set; }
        
        [Parameter(
            Mandatory = true,
            Position = 2,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public double Width { get; set; }

        [Parameter(
            Mandatory = true,
            Position = 3,
            ValueFromPipeline = true,
            ValueFromPipelineByPropertyName = true)]
        public string Name { get; set; }
        // This method gets called once for each cmdlet in the pipeline when the pipeline starts executing
        protected override void BeginProcessing()
        {
            WriteVerbose("Begin!");
        }

        // This method will be called for each input received from the pipeline to this cmdlet; if no input is received, this method is not called
        protected override void ProcessRecord()
        {
            var page = new VisioAutomation.Power.Elements.Page(this.Width, this.Height);
            page.Name = this.Name;
            this.InputObject.Pages.Add(page);
            WriteObject(this.InputObject);
        }

        // This method will be called once at the end of pipeline execution; if no input is received, this method is not called
        protected override void EndProcessing()
        {
            WriteVerbose("End!");
        }
    }
}
 