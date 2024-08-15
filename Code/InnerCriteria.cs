namespace BlazorWebAppTest.Code
{
	public class InnerCriteria
	{
		public string Filter2 { get; set; }

		// Because it is a nullable datatype (using int data type resolves the problem or commenting this property out)
		// I confirmed that any nullable type will cause the databind problem.
		public int? ThisFieldDeclarationCausesSubmitBug { get; set; }
	}
}
