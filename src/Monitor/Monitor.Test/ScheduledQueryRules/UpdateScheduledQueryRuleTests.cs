﻿using Microsoft.Azure.Commands.ScenarioTest;
using Microsoft.Azure.Management.Monitor;
using Microsoft.Rest.Azure;
using Microsoft.WindowsAzure.Commands.ScenarioTest;
using Moq;
using System.Collections.Generic;
using System.Management.Automation;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.Commands.Insights.OutputClasses;
using Xunit;
using Microsoft.Azure.Commands.Insights.ScheduledQueryRules;
using Microsoft.Azure.Management.Monitor.Management.Models;
using Microsoft.Azure.Management.Monitor.Models;
using ActivityLogAlertResource = Microsoft.Azure.Management.Monitor.Models.ActivityLogAlertResource;

namespace Microsoft.Azure.Commands.Insights.Test.ScheduledQueryRules
{
    public class UpdateScheduledQueryRuleTests
    {
        private readonly UpdateScheduledQueryRuleCommand cmdlet;
        private readonly Mock<MonitorManagementClient> monitorManagementClientMock;
        private readonly Mock<IScheduledQueryRulesOperations> sqrOperationsMock;
        private Mock<ICommandRuntime> commandRuntimeMock;
        private AzureOperationResponse<LogSearchRuleResource> response;
        private string resourceGroup;
        private string ruleName;
        private LogSearchRuleResource updatePrms;

        public UpdateScheduledQueryRuleTests(Xunit.Abstractions.ITestOutputHelper output)
        {
            ServiceManagement.Common.Models.XunitTracingInterceptor.AddToContext(new ServiceManagement.Common.Models.XunitTracingInterceptor(output));
            TestExecutionHelpers.SetUpSessionAndProfile();
            sqrOperationsMock = new Mock<IScheduledQueryRulesOperations>();
            monitorManagementClientMock = new Mock<MonitorManagementClient>() { CallBase = true };
            commandRuntimeMock = new Mock<ICommandRuntime>();

            //testing update of "enabled" field
            cmdlet = new UpdateScheduledQueryRuleCommand
            {
                CommandRuntime = commandRuntimeMock.Object,
                MonitorManagementClient = monitorManagementClientMock.Object,
                Enabled = "true"
            };

            response = new AzureOperationResponse<LogSearchRuleResource>()
            {
                Body = new LogSearchRuleResource()
            };

            sqrOperationsMock.Setup(f => f.GetWithHttpMessagesAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<Dictionary<string, List<string>>>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<Microsoft.Rest.Azure.AzureOperationResponse<LogSearchRuleResource>>(response))
                .Callback((string resourceGrp, string name) =>
                {
                    this.resourceGroup = resourceGrp;
                    this.ruleName = name;
                    this.updatePrms = response.Body;
                });

            sqrOperationsMock.Setup(f => f.CreateOrUpdateWithHttpMessagesAsync(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<LogSearchRuleResource>(), It.IsAny<Dictionary<string, List<string>>>(), It.IsAny<CancellationToken>()))
                .Returns(Task.FromResult<Microsoft.Rest.Azure.AzureOperationResponse<LogSearchRuleResource>>(response))
                .Callback((string resourceGrp, string name, LogSearchRuleResource updateParams, Dictionary<string, List<string>> headers, CancellationToken t) =>
                {
                    this.resourceGroup = resourceGrp;
                    this.ruleName = name;
                    this.updatePrms = updateParams;
                });

            monitorManagementClientMock.SetupGet(f => f.ScheduledQueryRules).Returns(this.sqrOperationsMock.Object);

            // Setup Confirmation
            commandRuntimeMock.Setup(f => f.ShouldProcess(It.IsAny<string>())).Returns(true);
            commandRuntimeMock.Setup(f => f.ShouldProcess(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            commandRuntimeMock.Setup(f => f.ShouldProcess(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(true);
            commandRuntimeMock.Setup(f => f.ShouldContinue(It.IsAny<string>(), It.IsAny<string>())).Returns(true);
        }


        [Fact]
        [Trait(Category.AcceptanceType, Category.CheckIn)]

        public void UpdateScheduledQueryRuleCommandParametersProcessing()
        {
            //testing update of description field

            cmdlet.RuleName = "LogSearchAlertName";
            cmdlet.ResourceGroupName = Utilities.ResourceGroup;

            /*
            ScheduledQueryRuleAznsAction aznsAction = new ScheduledQueryRuleAznsAction(new AzNsActionGroup());
            ScheduledQueryRuleTriggerCondition triggerCondition = new ScheduledQueryRuleTriggerCondition(new TriggerCondition("GreaterThan", 15));
            ScheduledQueryRuleAlertingAction alertingAction = new ScheduledQueryRuleAlertingAction(new AlertingAction("2", aznsAction, triggerCondition));

            cmdlet.Action = new PSScheduledQueryRuleAlertingAction(alertingAction);

            ScheduledQueryRuleSchedule schedule = new ScheduledQueryRuleSchedule(new Schedule(5, 5));
            cmdlet.Schedule = new PSScheduledQueryRuleSchedule(schedule);

            ScheduledQueryRuleSource source = new ScheduledQueryRuleSource(new Source("union *", "dataSourceId", new List<string> { "authResource1", "authResource2" }, "ResultCount"));
            cmdlet.Source = new PSScheduledQueryRuleSource(source);

            ScheduledQueryRuleResource sqrResource = new ScheduledQueryRuleResource(new LogSearchRuleResource(location: Location, source: source, schedule:schedule, action:alertingAction, name: "LogSearchAlertName", description: "A Log Search Alert description"));
            */

            cmdlet.Enabled = "false";
            cmdlet.ExecuteCmdlet();

            Assert.Equal("LogSearchAlertName", this.ruleName);
            Assert.Equal(Utilities.ResourceGroup, this.resourceGroup);

            Assert.NotNull(this.updatePrms);

            
            Assert.Equal("false", this.updatePrms.Enabled);

            Assert.Null(this.updatePrms.Id); // TBD

            Assert.NotNull(this.updatePrms.Action);

            Assert.NotNull(this.updatePrms.Schedule);
            Assert.Equal(5, this.updatePrms.Schedule.FrequencyInMinutes);
            Assert.Equal(5, this.updatePrms.Schedule.TimeWindowInMinutes);

            Assert.NotNull(this.updatePrms.Source);
            Assert.Equal("union *", this.updatePrms.Source.Query);
            Assert.Equal("dataSourceId", this.updatePrms.Source.DataSourceId);
            Assert.Equal(new List<string> { "authResource1", "authResource2" }, this.updatePrms.Source.AuthorizedResources);
            Assert.Equal("ResultCount", this.updatePrms.Source.QueryType);
        }
    }
}
