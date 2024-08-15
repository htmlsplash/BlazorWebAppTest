namespace BlazorWebAppTest.Code
{
	public class OuterCriteria
	{
		public int? SomeId { get; set; }
		public string Filter1 { get; set; }
        public InnerCriteria InnerCriteria { get; set; } = new InnerCriteria();
    }
}
