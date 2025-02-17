using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Cortside.MockServer.AccessControl.Models {
    public class Subject {
        public string ClientId { get; set; }
        public string SubjectId { get; set; }
        public List<SubjectClaim> Claims { get; set; }
        public string UserType { get; set; }

        // This site can be used to generate JWT tokens with desired values: http://jwtbuilder.jamiekurtz.com/
        public string ReferenceToken { get; set; }
        public List<Policy> Policies { get; set; }
    }

    public class SubjectClaim {
        public string Type { get; set; }
        public string Value { get; set; }
    }

    public class Authorization {
        public List<string> Roles { get; set; }
        public List<string> Permissions { get; set; }
        public List<ChildPolicyResult> ChildPolicies { get; set; }
    }

    public class Policy {
        public string PolicyName { get; set; }
        public Authorization Authorization { get; set; }
        public Guid? PolicyResourceId { get; set; }
    }

    public class ChildPolicyResult {
        public string Name { get; set; }
        public IEnumerable<string> Roles { get; set; }
        public IEnumerable<string> Permissions { get; set; }
    }

    public class Subjects {
        [JsonProperty("subjects")]
        public List<Subject> SubjectsList { get; set; }
    }
}
