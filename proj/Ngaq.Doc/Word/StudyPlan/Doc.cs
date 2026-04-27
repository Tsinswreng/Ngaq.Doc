namespace Ngaq.Doc.Word.StudyPlan;

using Tsinswreng.CsCore;

[Doc($$"""
#H[模塊概述][
	StudyPlan 前端頁面的目標是:
	- 在同一套界面中完成學習方案的選擇、編輯與刪除。
	- 將前置篩選器與權重配置的編輯能力收斂到可視化流程中。
]

#H[主要頁面][
	- {{nameof(Ngaq.Ui.Views.Word.WordManage.StudyPlan.SetCurStudyPlan.ViewSetCurStudyPlan)}}:
		設置當前學習方案，支持從列表選擇或進入編輯。
	- {{nameof(Ngaq.Ui.Views.Word.WordManage.StudyPlan.StudyPlanEdit.ViewStudyPlanEdit)}}:
		學習方案主編輯頁，關聯前置篩選器、權重計算器與權重參數。
	- {{nameof(Ngaq.Ui.Views.Word.WordManage.StudyPlan.PreFilterEdit.PreFilterVisualEdit.ViewPreFilterVisualEdit)}}:
		前置篩選器一體化編輯頁，含核心篩選器與屬性篩選器分頁。
	- {{nameof(Ngaq.Ui.Views.Word.WordManage.StudyPlan.WeightCalculatorEdit.ViewWeightCalculatorEdit)}}:
		權重計算器編輯頁，支持負載文本配置。
	- {{nameof(Ngaq.Ui.Views.Word.WordManage.StudyPlan.WeightArgPayloadJsonEdit.ViewWeightArgPayloadJsonEdit)}}:
		權重參數 JSON 配置頁。
]

#H[交互約定][
	- 同行同時存在刪除與保存按鈕時，刪除放在左側。
	- 需要用戶複製的 Id 字段使用可選中文本控件。
	- 關聯選擇操作使用帶圖標按鈕，減少歧義。
]

#H[js 權重算法自定義][
	- 權重計算器的 `PayloadText` 用於承載自定義算法配置文本。
	- 權重參數 JSON 與計算器配置分離：
		- 計算器頁負責算法主配置（如策略、腳本內容、版本號）。
		- 參數頁負責可變參數（如閾值、倍率、白名單）並可獨立調整。
	- 建議約定一套穩定鍵名，避免運行期因鍵名漂移造成解析失敗。
]

""")]
file class _{
	
}
