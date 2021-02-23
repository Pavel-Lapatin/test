using Nancy;

namespace VulnerableLibraries.Modules
{
    public class FooModule : NancyModule
    {
        public FooModule()
        {
            Get["Bar"] = parameters => { return "You have reached the /bar route"; };
        }
    }
}
