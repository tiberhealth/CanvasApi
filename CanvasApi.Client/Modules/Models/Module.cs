namespace CanvasApi.Client.Modules.Models
{
    internal class Module
    {
        public long Id { get; set; }
        //[JsonProperty("wokflow_state")] public IEnumerable<ModuleWorkflowState> WorkflowState { get; set; }
        public int Position { get; set; }
        public string Name { get; set; }
        public bool RequireSequentialProgression { get; set; }
        public int[] PrerequisiteModuleIds { get; set; }
        public int ItemsCount { get; set; }
        public string ItemsUrl { get; set; }
        //[JsonProperty("items")] public IModuleItem[] Items { get; set; }
        public bool PublishFinalGrade { get; set; }
    }
}
