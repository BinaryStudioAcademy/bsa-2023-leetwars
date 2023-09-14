import { ICodeRunRequest } from "@shared/models/code-run/code-run-request";

export function generateFakeCodeRunRequest(connectionId: string) {
    const exampleCodeRunRequest: ICodeRunRequest = {
        userConnectionId: connectionId,
        userId: 1234,
        challengeVersionId: 1234,
        language: 'csharp',
        userCode: 'public class Solution\r\n{\r\n    public bool IsNumPrime(int num)\r\n    ' +
                '{\r\n        throw new Exception("Exception!!!");\r\n    }\r\n}\r\n',
        preloaded: undefined,
        tests: 'using NUnit.Framework;\r\n\r\n[TestFixture]\r\npublic class Tests\r\n{\r\n    ' +
            'private Solution? _solutionClass;\r\n\r\n    [SetUp]\r\n    ' +
            'public void Setup()\r\n    {\r\n        _solutionClass = new Solution();\r\n    }\r\n\r\n    ' +
            '[Test]\r\n    public void IsPrime_InputIs1_ReturnFalse()\r\n    ' +
            '{\r\n        var result = _solutionClass.IsNumPrime(2);\r\n\r\n        ' +
            'Assert.IsFalse(result, "1 should not be prime");\r\n    }\r\n}',
    };

    return exampleCodeRunRequest;
}
