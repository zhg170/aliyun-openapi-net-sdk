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
using Aliyun.Acs.UniMkt.Model.V20181212;

namespace Aliyun.Acs.UniMkt.Transform.V20181212
{
    public class CheckDeviceResponseUnmarshaller
    {
        public static CheckDeviceResponse Unmarshall(UnmarshallerContext context)
        {
			CheckDeviceResponse checkDeviceResponse = new CheckDeviceResponse();

			checkDeviceResponse.HttpResponse = context.HttpResponse;
			checkDeviceResponse.Status = context.BooleanValue("CheckDevice.Status");
			checkDeviceResponse.Msg = context.StringValue("CheckDevice.Msg");
			checkDeviceResponse.ErrorCode = context.StringValue("CheckDevice.ErrorCode");
			checkDeviceResponse.RequestId = context.StringValue("CheckDevice.RequestId");

			List<CheckDeviceResponse.CheckDevice_PlanDto> checkDeviceResponse_plans = new List<CheckDeviceResponse.CheckDevice_PlanDto>();
			for (int i = 0; i < context.Length("CheckDevice.Plans.Length"); i++) {
				CheckDeviceResponse.CheckDevice_PlanDto planDto = new CheckDeviceResponse.CheckDevice_PlanDto();
				planDto.Id = context.LongValue("CheckDevice.Plans["+ i +"].Id");
				planDto.Name = context.StringValue("CheckDevice.Plans["+ i +"].Name");
				planDto.StartTime = context.StringValue("CheckDevice.Plans["+ i +"].StartTime");
				planDto.EndTime = context.StringValue("CheckDevice.Plans["+ i +"].EndTime");

				checkDeviceResponse_plans.Add(planDto);
			}
			checkDeviceResponse.Plans = checkDeviceResponse_plans;
        
			return checkDeviceResponse;
        }
    }
}
