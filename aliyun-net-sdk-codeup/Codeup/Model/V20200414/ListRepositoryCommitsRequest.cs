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
using System.Collections.Generic;

using Aliyun.Acs.Core;
using Aliyun.Acs.Core.Http;
using Aliyun.Acs.Core.Transform;
using Aliyun.Acs.Core.Utils;
using Aliyun.Acs.codeup;
using Aliyun.Acs.codeup.Transform;
using Aliyun.Acs.codeup.Transform.V20200414;

namespace Aliyun.Acs.codeup.Model.V20200414
{
    public class ListRepositoryCommitsRequest : RoaAcsRequest<ListRepositoryCommitsResponse>
    {
        public ListRepositoryCommitsRequest()
            : base("codeup", "2020-04-14", "ListRepositoryCommits")
        {
			UriPattern = "/api/v4/projects/[ProjectId]/repository/commits";
			Method = MethodType.GET;
        }

		private string accessToken;

		private bool? showSignature;

		private string refName;

		private string organizationId;

		private string path;

		private string search;

		private long? pageSize;

		private long? page;

		private long? projectId;

		public string AccessToken
		{
			get
			{
				return accessToken;
			}
			set	
			{
				accessToken = value;
				DictionaryUtil.Add(QueryParameters, "AccessToken", value);
			}
		}

		public bool? ShowSignature
		{
			get
			{
				return showSignature;
			}
			set	
			{
				showSignature = value;
				DictionaryUtil.Add(QueryParameters, "ShowSignature", value.ToString());
			}
		}

		public string RefName
		{
			get
			{
				return refName;
			}
			set	
			{
				refName = value;
				DictionaryUtil.Add(QueryParameters, "RefName", value);
			}
		}

		public string OrganizationId
		{
			get
			{
				return organizationId;
			}
			set	
			{
				organizationId = value;
				DictionaryUtil.Add(QueryParameters, "OrganizationId", value);
			}
		}

		public string Path
		{
			get
			{
				return path;
			}
			set	
			{
				path = value;
				DictionaryUtil.Add(QueryParameters, "Path", value);
			}
		}

		public string Search
		{
			get
			{
				return search;
			}
			set	
			{
				search = value;
				DictionaryUtil.Add(QueryParameters, "Search", value);
			}
		}

		public long? PageSize
		{
			get
			{
				return pageSize;
			}
			set	
			{
				pageSize = value;
				DictionaryUtil.Add(QueryParameters, "PageSize", value.ToString());
			}
		}

		public long? Page
		{
			get
			{
				return page;
			}
			set	
			{
				page = value;
				DictionaryUtil.Add(QueryParameters, "Page", value.ToString());
			}
		}

		public long? ProjectId
		{
			get
			{
				return projectId;
			}
			set	
			{
				projectId = value;
				DictionaryUtil.Add(PathParameters, "ProjectId", value.ToString());
			}
		}

		public override bool CheckShowJsonItemName()
		{
			return false;
		}

        public override ListRepositoryCommitsResponse GetResponse(UnmarshallerContext unmarshallerContext)
        {
            return ListRepositoryCommitsResponseUnmarshaller.Unmarshall(unmarshallerContext);
        }
    }
}
