/*
 * Copyright 2016 Game Server Services, Inc. or its affiliates. All Rights
 * Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 *
 *  http://www.apache.org/licenses/LICENSE-2.0
 *
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using Gs2.Core.Control;
using Gs2.Core.Model;
using Gs2.Gs2Lottery.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Lottery.Request
{
	[Preserve]
	[System.Serializable]
	public class GetLotteryModelMasterRequest : Gs2Request<GetLotteryModelMasterRequest>
	{

        /** ネームスペース名 */
		[UnityEngine.SerializeField]
        public string namespaceName;

        /**
         * ネームスペース名を設定
         *
         * @param namespaceName ネームスペース名
         * @return this
         */
        public GetLotteryModelMasterRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** 抽選モデルの種類名 */
		[UnityEngine.SerializeField]
        public string lotteryName;

        /**
         * 抽選モデルの種類名を設定
         *
         * @param lotteryName 抽選モデルの種類名
         * @return this
         */
        public GetLotteryModelMasterRequest WithLotteryName(string lotteryName) {
            this.lotteryName = lotteryName;
            return this;
        }


    	[Preserve]
        public static GetLotteryModelMasterRequest FromDict(JsonData data)
        {
            return new GetLotteryModelMasterRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                lotteryName = data.Keys.Contains("lotteryName") && data["lotteryName"] != null ? data["lotteryName"].ToString(): null,
            };
        }

	}
}