/*
 * Licensed to the Apache Software Foundation (ASF) under one
 * or more contributor license agreements.  See the NOTICE file
 * distributed with this work for additional information
 * regarding copyright ownership.  The ASF licenses this file
 * to you under the Apache License, Version 2.0 (the
 * "License"); you may not use this file except in compliance
 * with the License.  You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */
using System;
using System.Collections.Generic;

using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Config.Model.V20190108;

namespace Aliyun.Acs.Config.Transform.V20190108
{
    public class DescribeConfigRuleResponseUnmarshaller
    {
        public static DescribeConfigRuleResponse Unmarshall(UnmarshallerContext context)
        {
			DescribeConfigRuleResponse describeConfigRuleResponse = new DescribeConfigRuleResponse();

			describeConfigRuleResponse.HttpResponse = context.HttpResponse;
			describeConfigRuleResponse.RequestId = context.StringValue("DescribeConfigRule.RequestId");

			DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule configRule = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule();
			configRule.ConfigRuleArn = context.StringValue("DescribeConfigRule.ConfigRule.ConfigRuleArn");
			configRule.ConfigRuleId = context.StringValue("DescribeConfigRule.ConfigRule.ConfigRuleId");
			configRule.ConfigRuleName = context.StringValue("DescribeConfigRule.ConfigRule.ConfigRuleName");
			configRule.ConfigRuleState = context.StringValue("DescribeConfigRule.ConfigRule.ConfigRuleState");
			configRule.CreateTimestamp = context.LongValue("DescribeConfigRule.ConfigRule.CreateTimestamp");
			configRule.Description = context.StringValue("DescribeConfigRule.ConfigRule.Description");
			configRule.InputParameters = context.StringValue("DescribeConfigRule.ConfigRule.InputParameters");
			configRule.ModifiedTimestamp = context.LongValue("DescribeConfigRule.ConfigRule.ModifiedTimestamp");
			configRule.RiskLevel = context.IntegerValue("DescribeConfigRule.ConfigRule.RiskLevel");

			DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_CreateBy createBy = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_CreateBy();
			createBy.CreatorType = context.StringValue("DescribeConfigRule.ConfigRule.CreateBy.CreatorType");
			createBy.CreatorId = context.StringValue("DescribeConfigRule.ConfigRule.CreateBy.CreatorId");
			createBy.CreatorName = context.StringValue("DescribeConfigRule.ConfigRule.CreateBy.CreatorName");
			createBy.ConfigRuleSceneId = context.StringValue("DescribeConfigRule.ConfigRule.CreateBy.ConfigRuleSceneId");
			createBy.ConfigRuleSceneName = context.StringValue("DescribeConfigRule.ConfigRule.CreateBy.ConfigRuleSceneName");
			configRule.CreateBy = createBy;

			DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_ConfigRuleEvaluationStatus configRuleEvaluationStatus = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_ConfigRuleEvaluationStatus();
			configRuleEvaluationStatus.FirstActivatedTimestamp = context.LongValue("DescribeConfigRule.ConfigRule.ConfigRuleEvaluationStatus.FirstActivatedTimestamp");
			configRuleEvaluationStatus.FirstEvaluationStarted = context.BooleanValue("DescribeConfigRule.ConfigRule.ConfigRuleEvaluationStatus.FirstEvaluationStarted");
			configRuleEvaluationStatus.LastErrorCode = context.StringValue("DescribeConfigRule.ConfigRule.ConfigRuleEvaluationStatus.LastErrorCode");
			configRuleEvaluationStatus.LastErrorMessage = context.StringValue("DescribeConfigRule.ConfigRule.ConfigRuleEvaluationStatus.LastErrorMessage");
			configRuleEvaluationStatus.LastFailedEvaluationTimestamp = context.LongValue("DescribeConfigRule.ConfigRule.ConfigRuleEvaluationStatus.LastFailedEvaluationTimestamp");
			configRuleEvaluationStatus.LastFailedInvocationTimestamp = context.LongValue("DescribeConfigRule.ConfigRule.ConfigRuleEvaluationStatus.LastFailedInvocationTimestamp");
			configRuleEvaluationStatus.LastSuccessfulEvaluationTimestamp = context.LongValue("DescribeConfigRule.ConfigRule.ConfigRuleEvaluationStatus.LastSuccessfulEvaluationTimestamp");
			configRuleEvaluationStatus.LastSuccessfulInvocationTimestamp = context.LongValue("DescribeConfigRule.ConfigRule.ConfigRuleEvaluationStatus.LastSuccessfulInvocationTimestamp");
			configRule.ConfigRuleEvaluationStatus = configRuleEvaluationStatus;

			DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_ManagedRule managedRule = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_ManagedRule();
			managedRule.ManagedRuleName = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.ManagedRuleName");
			managedRule.Description = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.Description");
			managedRule.Identifier = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.Identifier");
			managedRule.CompulsoryInputParameterDetails = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.CompulsoryInputParameterDetails");
			managedRule.OptionalInputParameterDetails = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.OptionalInputParameterDetails");
			managedRule.HelpUrl = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.HelpUrl");

			List<string> managedRule_labels = new List<string>();
			for (int i = 0; i < context.Length("DescribeConfigRule.ConfigRule.ManagedRule.Labels.Length"); i++) {
				managedRule_labels.Add(context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.Labels["+ i +"]"));
			}
			managedRule.Labels = managedRule_labels;

			List<DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_ManagedRule.DescribeConfigRule_SourceDetailsItem> managedRule_sourceDetails = new List<DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_ManagedRule.DescribeConfigRule_SourceDetailsItem>();
			for (int i = 0; i < context.Length("DescribeConfigRule.ConfigRule.ManagedRule.SourceDetails.Length"); i++) {
				DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_ManagedRule.DescribeConfigRule_SourceDetailsItem sourceDetailsItem = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_ManagedRule.DescribeConfigRule_SourceDetailsItem();
				sourceDetailsItem.EventSource = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.SourceDetails["+ i +"].EventSource");
				sourceDetailsItem.MaximumExecutionFrequency = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.SourceDetails["+ i +"].MaximumExecutionFrequency");
				sourceDetailsItem.MessageType = context.StringValue("DescribeConfigRule.ConfigRule.ManagedRule.SourceDetails["+ i +"].MessageType");

				managedRule_sourceDetails.Add(sourceDetailsItem);
			}
			managedRule.SourceDetails = managedRule_sourceDetails;
			configRule.ManagedRule = managedRule;

			DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source source = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source();
			source.Identifier = context.StringValue("DescribeConfigRule.ConfigRule.Source.Identifier");
			source.Owner = context.StringValue("DescribeConfigRule.ConfigRule.Source.Owner");

			List<DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source.DescribeConfigRule_SourceConditionsItem> source_sourceConditions = new List<DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source.DescribeConfigRule_SourceConditionsItem>();
			for (int i = 0; i < context.Length("DescribeConfigRule.ConfigRule.Source.SourceConditions.Length"); i++) {
				DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source.DescribeConfigRule_SourceConditionsItem sourceConditionsItem = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source.DescribeConfigRule_SourceConditionsItem();
				sourceConditionsItem.DesiredValue = context.StringValue("DescribeConfigRule.ConfigRule.Source.SourceConditions["+ i +"].DesiredValue");
				sourceConditionsItem.Name = context.StringValue("DescribeConfigRule.ConfigRule.Source.SourceConditions["+ i +"].Name");
				sourceConditionsItem._Operator = context.StringValue("DescribeConfigRule.ConfigRule.Source.SourceConditions["+ i +"].Operator");
				sourceConditionsItem.Required = context.BooleanValue("DescribeConfigRule.ConfigRule.Source.SourceConditions["+ i +"].Required");
				sourceConditionsItem.SelectPath = context.StringValue("DescribeConfigRule.ConfigRule.Source.SourceConditions["+ i +"].SelectPath");
				sourceConditionsItem.Tips = context.StringValue("DescribeConfigRule.ConfigRule.Source.SourceConditions["+ i +"].Tips");

				source_sourceConditions.Add(sourceConditionsItem);
			}
			source.SourceConditions = source_sourceConditions;

			List<DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source.DescribeConfigRule_SourceDetailsItem2> source_sourceDetails1 = new List<DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source.DescribeConfigRule_SourceDetailsItem2>();
			for (int i = 0; i < context.Length("DescribeConfigRule.ConfigRule.Source.SourceDetails.Length"); i++) {
				DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source.DescribeConfigRule_SourceDetailsItem2 sourceDetailsItem2 = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Source.DescribeConfigRule_SourceDetailsItem2();
				sourceDetailsItem2.EventSource = context.StringValue("DescribeConfigRule.ConfigRule.Source.SourceDetails["+ i +"].EventSource");
				sourceDetailsItem2.MaximumExecutionFrequency = context.StringValue("DescribeConfigRule.ConfigRule.Source.SourceDetails["+ i +"].MaximumExecutionFrequency");
				sourceDetailsItem2.MessageType = context.StringValue("DescribeConfigRule.ConfigRule.Source.SourceDetails["+ i +"].MessageType");

				source_sourceDetails1.Add(sourceDetailsItem2);
			}
			source.SourceDetails1 = source_sourceDetails1;
			configRule.Source = source;

			DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Scope scope = new DescribeConfigRuleResponse.DescribeConfigRule_ConfigRule.DescribeConfigRule_Scope();
			scope.ComplianceResourceId = context.StringValue("DescribeConfigRule.ConfigRule.Scope.ComplianceResourceId");

			List<string> scope_complianceResourceTypes = new List<string>();
			for (int i = 0; i < context.Length("DescribeConfigRule.ConfigRule.Scope.ComplianceResourceTypes.Length"); i++) {
				scope_complianceResourceTypes.Add(context.StringValue("DescribeConfigRule.ConfigRule.Scope.ComplianceResourceTypes["+ i +"]"));
			}
			scope.ComplianceResourceTypes = scope_complianceResourceTypes;
			configRule.Scope = scope;
			describeConfigRuleResponse.ConfigRule = configRule;
        
			return describeConfigRuleResponse;
        }
    }
}
