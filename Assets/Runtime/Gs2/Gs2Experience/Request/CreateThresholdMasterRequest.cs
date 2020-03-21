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
using Gs2.Gs2Experience.Model;
using LitJson;
using UnityEngine.Scripting;

namespace Gs2.Gs2Experience.Request
{
	[Preserve]
	[System.Serializable]
	public class CreateThresholdMasterRequest : Gs2Request<CreateThresholdMasterRequest>
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
        public CreateThresholdMasterRequest WithNamespaceName(string namespaceName) {
            this.namespaceName = namespaceName;
            return this;
        }


        /** ランクアップ閾値名 */
		[UnityEngine.SerializeField]
        public string name;

        /**
         * ランクアップ閾値名を設定
         *
         * @param name ランクアップ閾値名
         * @return this
         */
        public CreateThresholdMasterRequest WithName(string name) {
            this.name = name;
            return this;
        }


        /** ランクアップ閾値マスターの説明 */
		[UnityEngine.SerializeField]
        public string description;

        /**
         * ランクアップ閾値マスターの説明を設定
         *
         * @param description ランクアップ閾値マスターの説明
         * @return this
         */
        public CreateThresholdMasterRequest WithDescription(string description) {
            this.description = description;
            return this;
        }


        /** ランクアップ閾値のメタデータ */
		[UnityEngine.SerializeField]
        public string metadata;

        /**
         * ランクアップ閾値のメタデータを設定
         *
         * @param metadata ランクアップ閾値のメタデータ
         * @return this
         */
        public CreateThresholdMasterRequest WithMetadata(string metadata) {
            this.metadata = metadata;
            return this;
        }


        /** ランクアップ経験値閾値リスト */
		[UnityEngine.SerializeField]
        public List<long?> values;

        /**
         * ランクアップ経験値閾値リストを設定
         *
         * @param values ランクアップ経験値閾値リスト
         * @return this
         */
        public CreateThresholdMasterRequest WithValues(List<long?> values) {
            this.values = values;
            return this;
        }


    	[Preserve]
        public static CreateThresholdMasterRequest FromDict(JsonData data)
        {
            return new CreateThresholdMasterRequest {
                namespaceName = data.Keys.Contains("namespaceName") && data["namespaceName"] != null ? data["namespaceName"].ToString(): null,
                name = data.Keys.Contains("name") && data["name"] != null ? data["name"].ToString(): null,
                description = data.Keys.Contains("description") && data["description"] != null ? data["description"].ToString(): null,
                metadata = data.Keys.Contains("metadata") && data["metadata"] != null ? data["metadata"].ToString(): null,
                values = data.Keys.Contains("values") && data["values"] != null ? data["values"].Cast<JsonData>().Select(value =>
                    {
                        return (long?)long.Parse(value.ToString());
                    }
                ).ToList() : null,
            };
        }

	}
}