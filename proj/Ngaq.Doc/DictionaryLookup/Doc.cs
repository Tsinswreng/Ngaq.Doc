namespace Ngaq.Doc.DictionaryLookup;

using Tsinswreng.CsCore;

[Doc($$"""
#H[模塊概述][
	詞典查詢由
	{{nameof(Ngaq.Backend.Domains.Dictionary.Svc.SvcDictionary)}}（後端）
	與
	{{nameof(Ngaq.Ui.Views.Dictionary.VmDictionary)}}（前端）協作完成。
]

#H[解析失敗處理約定][
	當後端拋出
	{{nameof(Ngaq.Core.Infra.Errors.KeysErr.Dictionary.LlmResponseParseFailed)}}
	時，前端不再回滾查詢前快照。

	具體要求:
	- 保留流式階段已展示的文本（不清空結果區）。
	- 保留
	{{nameof(Ngaq.Ui.Views.Dictionary.VmDictionary.LastLlmRawOutput)}}
	，供
	{{nameof(Ngaq.Ui.Views.Dictionary.LlmRawOutputEdit.ViewLlmRawOutputEdit)}}
	查看與編輯原始響應後重解析。
]

""")]
file class _{
	
}
