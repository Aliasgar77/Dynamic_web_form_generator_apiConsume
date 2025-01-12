namespace library_system.Models
{

    public class FieldModel
    {
        public int UserID { get; set; } = 1; // Default UserID
        public string FieldName { get; set; } = string.Empty;
        public string FieldType { get; set; } = string.Empty;
        public string FieldLabel { get; set; } = string.Empty;
        public List<string> Options { get; set; } = new List<string>();
        public bool IsRequired { get; set; }
    }
}
