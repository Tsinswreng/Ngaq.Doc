namespace Ngaq.Doc.Word.UserWordManage;

using Tsinswreng.CsCore;

[Doc($$"""
#H[模塊概述][
	用戶詞庫管理頁以
	{{nameof(Ngaq.Ui.Views.Word.WordManage.SearchWords.ViewSearchWords)}}
	為入口，負責搜索既有單詞、打開單詞編輯頁，以及承接手動新增單詞。
]

#H[自由加詞入口][
	當前提供兩個直接進入空白單詞編輯頁的入口：
	- {{nameof(Ngaq.Ui.Views.Word.WordManage.SearchWords.ViewSearchWords)}} 頂部工具列採用「左搜索、中輸入框、右自由加詞」布局。
	- {{nameof(Ngaq.Ui.Views.Dictionary.ViewDictionary)}} 在尚未查詞時的收藏按鈕。

	兩者都會打開
	{{nameof(Ngaq.Ui.Views.Word.WordEditV2.ViewWordEditV2)}}，
	並調用
	{{nameof(Ngaq.Ui.Views.Word.WordEditV2.VmWordEditV2.InitFreeAddDraft)}}
	建立空白草稿。
]

#H[空白草稿初始化約定][
	自由加詞建立的草稿要求：
	- 聚合根使用空白詞頭，等待用戶手動輸入。
	- 默認不帶屬性，但會預先補一條 ELearn.Add 學習記錄。
	- 時間字段在前端先初始化為當前時間，避免編輯頁首屏出現無效時間文本。
	- 詞典頁入口會把當前源語言預填到草稿語言字段；搜索頁入口則保持空白。
]

""")]
file class _{
	
}


