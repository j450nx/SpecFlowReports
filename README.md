1. After test case is in place download ExtentReports from NuGet
2. Create Hook folder and Hooks class
3. In Hooks class create these static variabls: extent, feature
4. In Hooks class create these variables: scenario, step
5. Below is the method structure in the Hooks class:
	[BeforeTestRun]
	[BeforeFeature]
	[BeforeScenario]
	[BeforeStep]

	[AfterStep]
	[AfterScenario]
	[AfterFeature]
	[AfterTestRun]

6. Run test
7. Report should generate in the project folder