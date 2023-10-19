using System;

namespace XyloCode.ThirdPartyServices.RussianPost.Helpers
{
    [System.AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class IsQueryStringAttribute : Attribute
    {
        public IsQueryStringAttribute() { }
    }
}