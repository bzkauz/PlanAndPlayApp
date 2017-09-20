namespace Models
{
    using System;
    public class Registration
    {
        public int      Id                  { get; set; } 
        public Guid     GuidLoginTemp       { get; set; }/* used for first registration*/
        public Guid     GuidID              { get; set; }/* acitv token*/
        public DateTime StartLastUsed       { get; set; }/* last registerd time*/
        public DateTime RegistetTime        { get; set; }/* start of registered time*/
        public string   RegisterName        { get; set; }/* Login mail*/
        public string   RegisterPassword    { get; set; }/* Password */ 
    }
}
