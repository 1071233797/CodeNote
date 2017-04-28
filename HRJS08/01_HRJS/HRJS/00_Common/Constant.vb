''' <summary>
''' 全局変数の定義クラス
''' </summary>
''' <remarks></remarks>
''' <history>
''' [ ] 2013/01/04	Created
''' </history>
Public Class Constant

#Region "変数"

    Public Shared LoginInfo As St_Login_Info         'ログイン情報
    Public Shared ConfigInfo As St_Config_Info       '配置情報

    '画面背景色
    Public Shared Color_DB_Form_BackColor As Drawing.Color

    '業務機能ラベル背景色
    Public Shared Color_DB_LableB_BackColor As Drawing.Color

    'マスタ機能ラベル背景色
    Public Shared Color_DB_LableM_BackColor As Drawing.Color

    '表示項目背景色
    Public Shared Color_DB_ReadOnly_BackColor As Drawing.Color

    'フォーム閉じるメッセージのフラグ
    Public Shared FormCloseMessageFlg As Boolean = True

    'フォームを保存する
    Public Shared FormList As ArrayList = New ArrayList
    Public Shared FormList画像 As ArrayList = New ArrayList
    Public Shared FormNameList As ArrayList = New ArrayList

#End Region

#Region "定数"
    'DB Name
    Public Const CON_DATABASE_NAME As String = "HRJS"
    'CSV
    Public Const CON_CSV_F As String = Chr(34)
    Public Const CON_CSV_B As String = Chr(34)

    '記号
    Public Const CON_BRACKETS_LEFT As String = "("                  '左カッコ
    Public Const CON_BRACKETS_RIGHT As String = ")"                 '右カッコ
    Public Const CON_ALL_SPACE As String = "　"                     '全角空白
    Public Const CON_HALF_SPACE As String = " "                     '半角空白
    Public Const CON_ALL_STAR As String = "★"                      '全角星
    Public Const CON_ALL_ROUND As String = "○"                     '全角丸
    Public Const CON_ALL_DIVERGE As String = ""                     '全角ばつ
    Public Const CON_ALL_KAKERU As String = "×"                     '全角かける
    Public Const CON_PERCENT As String = "%"                        'パーセント
    Public Const CON_ENTER As String = "\n"                         '改行符
    Public Const CON_BIGBRACKETS_LEFT As String = "["               '左大カッコ
    Public Const CON_BIGBRACKETS_RIGHT As String = "]"              '右大カッコ
    Public Const CON_ALL_B As String = "＋"                         '全角のプラス
    Public Const CON_ALL_M As String = "▲"                         '全角のマイナス

    'ComBoxのブランク値
    Public Const cgintValueNull As String = "9999"
    Public Const cgDecValueNull As Decimal = -999999999999
    Public Const cgintBlank As Integer = -99
    Public Const cgintDefault As Integer = -1

    'NULL
    Public Const cgstr_NULL As String = "NULL"

    'CSV出力
    Public Const cgstrVO部門一覧 As String = "VO部門一覧"
    Public Const cgstrVO担当者一覧 As String = "VO担当者一覧"

    '日付型のデフォルト値
    Public Const cgStrDateFormat1 As String = "yyyy/MM/dd"

    Public Const CGSTRDATE_DEFAULT As String = "1900/01/01"
    Public Const cgstrDATE_FORMATDAY1 As String = "yy/MM/dd"
    Public Const cgstrDATE_FORMATDAY2 As String = "yy/mm/dd"
    Public Const cgstrDATE_FORMATDAY3 As String = "yyyyMMdd"
    Public Const cgstrDATE_FORMATDAY5 As String = "yyyyMMddHHmmss"
    Public Const cgstrDATE_FORMATDAY6 As String = "yyyy/MM/dd HH:mm:ss"
    Public Const cgstrDATE_FORMATDATETIME As String = "yyyy/MM/dd HH:mm:ss"
    Public Const cgstrDATE_EMPTY As String = "0001/01/01 0:00:00"

    'TAB+ENTER
    Public Const cgintTabKey1 As Integer = 1
    Public Const cgintTabKey2 As Integer = 2
    Public Const cgintTabKey3 As Integer = 3
    Public Const cgintTabKey4 As Integer = 4

    '削除フラグ
    Public Const cgint削除フラグ As Integer = 1

    'ステータス
    Public Const cgStrSTATUS新 As String = "新"
    Public Const cgStrSTATUS更 As String = "更"
    Public Const cgStrSTATUS削 As String = "削"

    '受注区分
    Public Const cgstr_受注区分_買取受注 As String = "01"
    Public Const cgstr_受注区分_委託受注 As String = "02"
    Public Const cgstr_受注区分_買取取置 As String = "11"
    Public Const cgstr_受注区分_委託取置 As String = "12"
    Public Const cgstr_受注区分_修理 As String = "21"
    Public Const cgstr_受注区分_社販 As String = "31"
    Public Const cgstr_受注区分_買取BOX出荷 As String = "41"
    Public Const cgstr_受注区分_委託BOX出荷 As String = "42"

    '受注形態区分
    Public Const cgstr_受注形態区分_買取 As String = "1"
    Public Const cgstr_受注形態区分_委託 As String = "2"
    Public Const cgstr_受注形態区分_EOS As String = "3"

    '売上区分
    Public Const cgstr_売上区分_買取売上 As String = "01"
    Public Const cgstr_売上区分_委託売上 As String = "02"
    Public Const cgstr_売上区分_リベート売上 As String = "03"
    Public Const cgstr_売上区分_買取返品 As String = "11"
    Public Const cgstr_売上区分_委託返却 As String = "12"

    '返品区分
    Public Const cgstr_返品区分_買取返品 As String = "1"
    Public Const cgstr_返品区分_委託返却 As String = "2"

    '諸口区分
    Public Const cgstr_諸口区分_一般 As String = "0"
    Public Const cgstr_諸口区分_諸口 As String = "1"

    '倉庫区分
    Public Const cgstr_倉庫区分_一般 As String = "1"
    Public Const cgstr_倉庫区分_委託 As String = "2"

    '大分類CD区分
    Public Const cgstr_大分類CD区分_BOX As String = "b"
    Public Const cgstr_大分類CD区分_パーツ As String = "p"
    Public Const cgstr_大分類CD区分_ウォッチ As String = "w"

    '引当状態区分
    Public Const cgstr_引当状態区分_未引当 As String = "1"
    Public Const cgstr_引当状態区分_引当済 As String = "2"
    Public Const cgstr_引当状態区分_一部引当 As String = "3"

    '伝票区分
    Public Const cgstr_伝票区分_通常 As String = "1"
    Public Const cgstr_伝票区分_赤伝 As String = "2"

    '受注残区分
    Public Const cgstr_受注残区分_有 As String = "1"
    Public Const cgstr_受注残区分_無 As String = "2"

    '印刷状態区分
    Public Const cgstr_印刷状態区分_未 As String = "1"
    Public Const cgstr_印刷状態区分_済 As String = "2"

    '同梱別送区分
    Public Const cgstr_同梱別送区分_別送 As String = "0"
    Public Const cgstr_同梱別送区分_同梱 As String = "1"

    '在庫管理区分
    Public Const cgstr_在庫管理区分_する As String = "0"
    Public Const cgstr_在庫管理区分_しない As String = "1"

    '商品名変更区分
    Public Const cgstr_商品名変更区分_しない As String = "0"
    Public Const cgstr_商品名変更区分_する As String = "1"

    'リスト．コンボボックス
    Public Const cgstrV_NM承認申請対象区分 As String = "NM承認申請対象区分"

    '承認申請対象区分
    Public Const cgstr_受注_得意先与信限度額超過時 As String = "01"
    Public Const cgstr_受注_時計下代変更時_下限価格以上 As String = "02"
    Public Const cgstr_受注_パーツ下代変更時_下限価格以上 As String = "03"
    Public Const cgstr_受注_時計下代変更時_下限価格未満 As String = "04"
    Public Const cgstr_受注_パーツ下代変更時_下限価格未満 As String = "05"
    Public Const cgstr_受注_高額出荷時 As String = "06"
    Public Const cgstr_受注_委託受注時 As String = "07"
    Public Const cgstr_受注_取置受注時 As String = "08"
    Public Const cgstr_返品_下代価格変更時 As String = "09"
    Public Const cgstr_返品_請求先相違時 As String = "10"
    Public Const cgstr_見積_下代価格変更時 As String = "11"

    '承認状態区分
    Public Const cgstr_承認状態区分_未申請 As String = "00"
    Public Const cgstr_承認状態区分_申請中 As String = "01"
    Public Const cgstr_承認状態区分_承認済 As String = "02"
    Public Const cgstr_承認状態区分_却下 As String = "03"

    '承認区分
    Public Const cgstr_承認区分_申請 As String = "1"
    Public Const cgstr_承認区分_承認 As String = "2"
    Public Const cgstr_承認区分_却下 As String = "3"

    '承認申請処理
    Public Const cgstr_承認申請処理_見積 As String = "00"              '機能CD＝00（見積）
    Public Const cgstr_承認申請処理_受注 As String = "10"
    Public Const cgstr_承認申請処理_返品 As String = "20"

    '代理承認表示区分
    Public Const cgstr_代理承認表示区分_含む As String = "1"
    Public Const cgstr_代理承認表示区分_含まない As String = "0"

    'NM消費税算出区分
    Public Const cgstr_消費税算出区分_明細単位 As String = "1"
    Public Const cgstr_消費税算出区分_伝票単位 As String = "2"
    Public Const cgstr_消費税算出区分_請求一括 As String = "3"
    Public Const cgstr_消費税算出区分_計算しない As String = "4"

    '帳端区分
    Public Const cgstr_帳端区分_今回 As String = "0"
    Public Const cgstr_帳端区分_次回 As String = "1"

    '取引先種類区分
    Public Const cgstr_取引先種類区分_得意先 As String = "1"
    Public Const cgstr_取引先種類区分_仕入先 As String = "2"
    Public Const cgstr_取引先種類区分_納入先 As String = "3"

    'ボタン名
    'InheritsSearchForm
    Public Const CON_BUTTON_RESET As String = "btnF1清空"           '清空
    Public Const CON_BUTTON_SEARCH As String = "btnF2查询"          '查询
    Public Const CON_BUTTON_SELECTION As String = "btnF3选择"       '选择
    Public Const CON_BUTTON_CLOSE As String = "btnF12关闭"           '「閉じる」ボタン

    'InheritsMasterForm
    'Public Const CON_BUTTON_RESET As String = "btnF1清空"           '清空
    Public Const CON_BUTTON_UPDATE As String = "btnF2编辑"           '编辑
    Public Const CON_BUTTON_SAVE As String = "btnF3保存"             '保存
    Public Const CON_BUTTON_DELETE As String = "btnF4删除"           '删除
    'Public Const CON_BUTTON_CLOSE As String = "btnF12关闭"           '「閉じる」ボタン
    Public Const CON_BUTTON_BACKUP As String = "btnF11备份"          '备份数据库


    Public Const CON_BUTTON_CLEAR As String = "btnF5取消"            '「クリア」ボタン
    Public Const CON_BUTTON_COPY As String = "btnF1複写"             '「複写」ボタン
    Public Const CON_BUTTON_CSVOUTPUT As String = "btnCSV出力"        '「CSV出力」ボタン
    Public Const CON_BUTTON_NEW As String = "btnF2新規"              '「新規」ボタン
    Public Const CON_BUTTON_ENTRY As String = "btnF11登録"           '「登録」ボタン
    Public Const CON_BUTTON_REFERRALS As String = "btnF1清空"        '「照会」ボタン
    'Public Const CON_BUTTON_SEARCH As String = "btnF9検索"           '「検索」ボタン
    'Public Const CON_BUTTON_SELECTION As String = "btnF1選択"        '「選択」ボタン
    'Public Const CON_BUTTON_REFERRALS As String = "btnF1清空"        '「照会」ボタン
    'Public Const CON_BUTTON_COPY As String = "btnF1複写"             '「複写」ボタン
    'Public Const CON_BUTTON_NEW As String = "btnF2新規"              '「新規」ボタン
    'Public Const CON_BUTTON_UPDATE As String = "btnF3修正"           '「変更」ボタン
    'Public Const CON_BUTTON_DELETE As String = "btnF4削除"           '「削除」ボタン
    'Public Const CON_BUTTON_CLEAR As String = "btnF5取消"            '「クリア」ボタン

    Public Const CON_BUTTON_F7 As String = "btnF7"

    Public Const CON_BUTTON_F8 As String = "btnF8"

    Public Const CON_BUTTON_F10 As String = "btnF10"

    Public Const CON_BUTTON_F11 As String = "btnF11"
    'Public Const CON_BUTTON_ENTRY As String = "btnF11登録"           '「登録」ボタン

    ''Public Const CON_BUTTON_SELECTION As String = "btnF1選択"        '「選択」ボタン
    ''Public Const CON_BUTTON_SEARCH As String = "btnF9検索"           '「検索」ボタン

    'Public Const CON_BUTTON_CSVOUTPUT As String = "btnCSV出力"        '「CSV出力」ボタン

    'Public Const CON_BUTTON_PRINT As String = "btnPrint"             '「印刷」ボタン
    'Public Const CON_BUTTON_OTHER As String = "btnOther"             '「その他」ボタン

    'Public Const CON_BUTTON_RESET As String = "btnF1清空"
    'Public Const CON_BUTTON_SEARCH As String = "btnF2编辑"
    'Public Const CON_BUTTON_SELECTION As String = "btnF3选择"

    'Public Const CON_BUTTON_CLOSE As String = "btnF12关闭"           '「閉じる」ボタン

    'Public Const CON_BUTTON_DELETE As String = "btnF4删除"

    '倉庫初期値
    Public Const cgstr_発注詳細_倉庫 As String = "P1012"

    Public Const cgstr_出力前後区分_前 As String = "1"
    Public Const cgstr_出力前後区分_後 As String = "2"

#Region "正規表現を使った文字列"
    '数字(0-100)
    Public Const CON_REGEX_NUMBER_0_100 As String = "^(\d{1,2}|100)$"

    '整数(0-9)
    Public Const CON_REGEX_NUMBER As String = "^[0-9]*$"

    '整数(0-9)と半角空白
    Public Const CON_REGEX_NUMBERBLANK As String = "^[0-9\-\x20]*$"

    '英文数字(A-Z,a-z,0-9)
    Public Const CON_REGEX_ALPHANUMERIC As String = "^[A-Z,a-z,0-9]*$"

    Public Const CON_REGEX_PASSWORD As String = "^(?=[0-9]*[A-z]+)(?=[A-z]*[0-9]+)"

    '電話番号(0-9)と(-)
    Public Const CON_REGEX_TEL As String = "^[-0-9]*$"
#End Region

#End Region

#Region "列挙型"
    '採番区分
    Public Enum ENU_採番区分 As Integer

        受注 = 10             '受注
        売上 = 11             '売上
        請求 = 12             '請求
        入金 = 13             '入金
        出荷 = 14             '出荷
        検品 = 15             '検品
        返品 = 16             '返品
        承認 = 17             '承認
        発注 = 20             '発注
        仕入 = 21             '仕入
        入出庫入力 = 30       '入出庫入力
        入出庫履歴 = 31       '入出庫履歴
        在庫配分 = 32         '在庫配分
        修理リスト = 33       '修理リスト
        製品取込 = 34         '製品取込
        引当 = 35             '引当

    End Enum

    Public Enum ReporyType As Integer
        ''' <summary>
        ''' 流转票
        ''' </summary>
        ''' <remarks></remarks>
        流转票 = 0 '流转票
        ''' <summary>
        ''' 出荷指示
        ''' </summary>
        ''' <remarks></remarks>
        出荷指示 = 1 '出荷指示
        ''' <summary>
        ''' 原材料采购单
        ''' </summary>
        ''' <remarks></remarks>
        原材料采购单 = 2 '原材料采购单
        ''' <summary>
        ''' 原材料标签
        ''' </summary>
        ''' <remarks></remarks>
        原材料标签 = 3 '原材料标签
        ''' <summary>
        ''' 半成品标签
        ''' </summary>
        ''' <remarks></remarks>
        半成品标签 = 4 '半成品标签
        ''' <summary>
        ''' 成品标签

        ''' </summary>
        ''' <remarks></remarks>
        成品标签 = 5 '成品标签

        ''' <summary>
        '''原材料出库单
        ''' </summary>
        ''' <remarks></remarks>
        原材料出库单 = 6

        ''' <summary>
        '''原材料出库单
        ''' </summary>
        ''' <remarks></remarks>
        原材料入库单 = 7

        ''' <summary>
        '''半成品入库单
        ''' </summary>
        ''' <remarks></remarks>
        半成品入库单 = 8

        ''' <summary>
        ''' 成品入库单
        ''' </summary>
        ''' <remarks></remarks>
        成品入库单 = 9
        ''' <summary>
        ''' label发行（包装）
        ''' </summary>
        ''' <remarks></remarks>
        SBoxPrintRecordT = 8
        ''' <summary>
        ''' 制品发行
        ''' </summary>
        ''' <remarks></remarks>
        ProductNumberRecordT = 9
        ''' <summary>
        ''' 原材料发行
        ''' </summary>
        ''' <remarks></remarks>
        MaterialRecordT = 10
        ''' <summary>
        ''' 工程作业票发行
        ''' </summary>
        ''' <remarks></remarks>
        ProjectRecordT = 11
        ''' <summary>
        ''' 消耗品发行
        ''' </summary>
        ''' <remarks></remarks>
        ConsumablesRecordT = 12
        ''' <summary>
        ''' 不良品一览发行
        ''' </summary>
        ''' <remarks></remarks>
        UnhealthReasons = 13
        ''' <summary>
        ''' 见积
        ''' </summary>
        ''' <remarks></remarks>
        OfferRecordT = 14

    End Enum
    '承認区分
    Public Enum ENU_承認区分 As Integer
        申請 = 1
        承認 = 2
        却下 = 3
    End Enum

    '在庫管理区分
    Public Enum ENU_在庫管理区分 As Integer
        する = 0
        しない = 1
    End Enum

    '伝票区分
    Public Enum ENU_伝票区分 As Integer
        通常 = 1
        赤伝 = 2
    End Enum

    '消費税算出区分
    Public Enum ENU_消費税算出区分 As Integer
        明細単位 = 1
        伝票単位 = 2
        請求一括 = 3
        計算しない = 4
    End Enum

    '選択状態
    Public Enum ENU_選択状態 As Integer
        選択 = 1
        選択なし = 0
    End Enum

    '諸口区分
    Public Enum ENU_諸口区分 As Integer
        一般 = 0
        諸口 = 1
    End Enum

    '受注形態区分
    Public Enum ENU_受注形態区分 As Integer
        買取り = 1
        委託 = 2
        EOS = 3
    End Enum

    Public Enum ENU_端数処理小数桁数 As Integer
        小数点一位 = 1
        小数点二位 = 2
        小数点三位 = 3
        小数点四位 = 4
    End Enum

    '売上形態区分
    Public Enum ENU_売上形態区分 As Integer
        買取 = 1
        委託 = 2
        EOS = 3
        修理 = 4
        誤差調整 = 5
    End Enum

    Public Enum ENU_帳端区分 As Integer
        今回 = 0
        次回 = 1
    End Enum

    '売上明細区分
    Public Enum ENU_売上明細区分 As Integer
        売上 = 1
        消費税 = 2
        請求消費税誤差 = 3
        売掛消費税誤差 = 4
    End Enum

    '同梱別送区分
    Public Enum ENU_同梱別送区分 As Integer
        別送 = 0
        同梱 = 1
    End Enum

    Public Enum ENU_取引先種類区分 As Integer
        得意先 = 1
        仕入先 = 2
        納入先 = 3
    End Enum

    Public Enum ENU_休日区分 As Integer

        稼 = 0                   '稼働日
        休 = 1                   '休日

    End Enum

    '入金区分
    Public Enum ENU_入金区分 As Integer

        入金 = 1
        振元 = 2
        振先 = 3

    End Enum

    '決済条件区分
    Public Enum ENU_決済条件区分 As Integer

        銀行振込 = 1
        手形 = 2
        小切手 = 3
        振替入金 = 4

    End Enum

    'メッセージの戻り値
    Public Enum ENU_SHOWMSG As Integer

        showMsgOK = DialogResult.OK               'OK時
        showMsgYes = DialogResult.Yes             'YES時
        showMsgNo = DialogResult.No               'NO時
        showMsgCancel = DialogResult.Cancel       'CANCEL時
        showMsgNotFound = 99        'ない時
        showMsgError = 98           'エラー時
    End Enum

    Public Enum ENU_RETURNTYPE As Integer

        Failed = -1                         'データベースを処理する戻り値
        Message = 0                         'データベースを処理する戻り値
        Succeed = 1                         'データベースを処理する戻り値
        PKExist = 2                         'データベースを処理する戻り値  主Ｋｅｙ重複
        Deleted = 3                         'データベースを処理する戻り値
        Exclusive = 4                       'データベースを処理する戻り値  排他
        エラーチェック = 5                  'データベースを処理する戻り値
        NotDelete = 6                  'データベースを処理する戻り値

    End Enum

    Public Enum ENU_MSTSEARCH As Integer
        SearchMOk = 1               '検索画面でボタン「選択」が押された場合
        SearchMCancel = 2           '検索画面でボタン「閉じる」が押された場合
    End Enum

    Public Enum ENU_MSTPASSWORD As Integer
        PassWordMOk = 1               '検索画面でボタン「選択」が押された場合
        PassWordMCancel = 2           '検索画面でボタン「閉じる」が押された場合
    End Enum


    Public Enum ENU_初期検索フラグ As Integer
        検索 = 1
        非検索 = 0
    End Enum

    Public Enum ENU_CHECK As Integer
        NASI = 0                '0:無効
        YUKO = 1                '1:有効

    End Enum

    '消込残高
    Public Enum ENU_消込残高 As Integer

        両方無効 = 0
        あり = 1
        なし = 2
        両方有効 = 3

    End Enum

    '得意先名
    Public Enum ENU_得意先名 As Integer

        両方無効 = 0
        あり = 1
        なし = 2
        両方有効 = 3

    End Enum

    Public Structure St_Login_Info

        Dim UserID As String                        'ユーザーのコード
        Dim UserName As String                      'ユーザー名
        Dim UserProwerCode As String                'ユーザー権限コード「権限コードについて、権限フラグを戻る0：使用不可、1：照会のみ、2：使用可」
        Dim UserPC As String                        'ユーザーPC
        Dim UserIP As String                        'ユーザーIP

    End Structure


    Public Structure St_Config_Info

        Dim DBConnectionString As String            'DB連接文字
        Dim DBTimeOut As Integer                    'DB連接アウト時間
        Dim LOGSQLFlg As String                     'SQL文ログフラグ(0:ログ出力しない 1:ログ出力)
        Dim LOGExceptionFlg As String               '異常ログフラグ(0:ログ出力しない 1:ログ出力)
        Dim LOGTransactionFlg As String             '事務ログフラグ(0:ログ出力しない 1:ログ出力)
        Dim DBConnectionError As String             'DB接続失敗
        Dim LOGApproval As String                   'お知らせ更新処理。承認履歴に更新処理する

    End Structure


    Public Enum ENU_MSGID As Integer
        'MSGID                                           '类型              ‘文本

        MSGID1 = 1                                        '4                确认要关闭画面吗？
        MSGID2 = 2                                        '4                确认要保存数据吗？
        MSGID3 = 3                                        '4                确认要变更数据吗？
        MSGID4 = 4                                        '4                确认要删除数据吗？
        MSGID5 = 5                                        '4                确认要打印数据吗?

        MSGID6 = 6                                        '4                确认要清空画面吗？
        MSGID7 = 7                                        '4                数据内容取消吗？

        MSGID8 = 8                                        '1                \1数据保存完成。\1=处理名
        MSGID9 = 9                                        '1                \1数据保存失败。
        MSGID10 = 10                                      '1                \1数据导出完成。\1=文件名
        MSGID11 = 11                                       '                

        MSGID12 = 12                                       '2                选择的基础数据在使用中，不能删除。
        MSGID13 = 13                                       '2                \1的值不能为空。\n请录入\1的值。\1=项目名
        MSGID14 = 14                                       '2                录入的编号不存在。\n请在\1的基础数据画面确认。\1=基础数据画面名
        MSGID15 = 15                                       '2                \1数据录入范围不正确。\1=项目名
        MSGID16 = 16                                       '2                数据不存在。
        MSGID17 = 17                                       '2                录入的编号不存在。
        MSGID18 = 18                                       '2                没有选择对应的数据行。
        MSGID19 = 19                                       '2                对应数据已经变更或被删除了。\n请重新查询。
        MSGID20 = 20                                       '2                录入的数据\1在数据库中已经存在。
        MSGID21 = 21                                       '2                数据重复，不能保存。\n请修改后重新保存。
        MSGID22 = 22                                       '2                相同批次已经存在。
        MSGID23 = 23                                       '2                超过有效位数。请重新确认值。
        MSGID24 = 24                                       '2                至少录入一条详细数据。
        MSGID25 = 25                                       '2                导入文件的格式和标准格式不一致。
        MSGID26 = 26                                       '2                库存数量不足。无法出库。
        MSGID27 = 27                                       '2                扫描的批次号不在预定范围内，请重新确认。
        MSGID28 = 28                                       '2                数据删除失败。
        MSGID29 = 29                                       '2                \1处理失败。
        MSGID30 = 30                                       '2                \1只能输入数字。
        MSGID31 = 31                                       '2                \1数据已确认，不可删除。
        MSGID32 = 32                                       '2                \1数据已确认，不可删除。
        MSGID33 = 33                                       '2                \1数据已确认，不可删除。
        MSGID34 = 34                                       '4                \1数据已确认，不可删除。
        MSGID35 = 35                                       '4                \1数据已确认，不可删除。
        MSGID36 = 36                                       '4                \1数据已确认，不可删除。
        MSGID37 = 37                                       '4                \1数据已确认，不可删除。
        MSGID38 = 38                                       '2                \1数据已确认，不可删除。
        MSGID39 = 39                                       '2                \1数据已确认，不可删除。
        MSGID40 = 40                                       '2                

        ErrorDbOpen = 901                                  '3                数据库连接失败。
        MSGID999 = 999                                     '3                程序发生异常。\n请保存画面后与系统管理者联系。
        MSGID41 = 41
        MSGID42 = 42
        MSGID43 = 43                                       '2                导入的图片已经不存在选择的历经,请重新选择.。
        MSGID44 = 44                                       '2                该图片已经存在数据库中。        MSGID45 = 45                                       '2                该货位正在被使用，不可以删除。
    End Enum

  
    Public Enum ENU_MODE As Integer

        Model_NULL = 0                    'モードなし
        Model_New = 1                     '新規モード
        Model_Copy = 2                    '複写モード
        Model_Update = 3                  '修正モード
        Model_Ref = 4                     '参照モード
        Model_Delete = 5                  '削除モード
        Model_Search = 6                  '検索モード(マスタから名称を取得)

        Model_Update_1 = 8                '更新１モード
        Model_Update_2 = 9                '更新２モード

        Model_Output = 10                 '出力後
        Model_RedUpdate = 98              '赤伝修正モード
        Model_Red = 99                    '赤伝モード(仕入詳細)


    End Enum

    ''' <summary>
    ''' 選択項目をセットする
    ''' </summary>
    ''' <remarks>選択項目をセットする</remarks>
    Public Enum enuSelect As Integer
        select得意先検索 = 1
        select銀行検索 = 2
        select銀行支店検索 = 3
    End Enum

    Public Enum ENU_部門事業所区分 As Integer
        部門 = 1
        事業所 = 2
    End Enum

    Public Enum ENU_倉庫区分 As Integer
        一般 = 1
        委託 = 2
    End Enum

    Public Enum ENU_削除区分 As Integer
        削除なし = 0
        削除 = 1
    End Enum

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Enum_金額端数区分 As Integer
        切り上げ = 0
        切り捨て = 1
        四捨五入 = 2
    End Enum

    Public Enum Enum_金額種類 As Integer
        受注金額 = 0
        仕入金額 = 1
        売上金額 = 2
        発注金額 = 3
        その他金額 = 9
    End Enum

#End Region

#Region "DB連絡エラー"

    'DB連絡エラー
    Public Const CON_OPENDB_ERROR As String = "DBConnError"
    '日付型空値
    Public Const cgStrDateTime_Default As String = "0001/01/01 0:00:00"

#End Region

#Region "画面名称"

    '見積管理
    Public Const FORM_NAME_見積管理 As String = "見積管理"
    Public Const FORM_NAME_受注管理 As String = "受注管理"
    Public Const FORM_NAME_売上管理 As String = "売上管理"
    Public Const FORM_NAME_請求管理 As String = "請求管理"
    Public Const FORM_NAME_入金管理 As String = "入金管理"
    Public Const FORM_NAME_出荷指示一覧 As String = "出荷指示一覧"
    Public Const FORM_NAME_一括出荷指示 As String = "一括出荷指示"
    Public Const FORM_NAME_ピッキングリスト印刷 As String = "ピッキングリスト印刷"
    Public Const FORM_NAME_出荷検品 As String = "出荷検品"
    Public Const FORM_NAME_返品管理 As String = "返品管理"
    Public Const FORM_NAME_承認管理 As String = "承認管理"
    Public Const FORM_NAME_月次管理 As String = "月次管理"

    '購買管理
    Public Const FORM_NAME_発注管理 As String = "発注管理"
    Public Const FORM_NAME_仕入管理 As String = "仕入管理"

    '在庫管理
    Public Const FORM_NAME_在庫照会 As String = "在庫照会"
    Public Const FORM_NAME_入出庫入力 As String = "入出庫入力"
    Public Const FORM_NAME_配分処理 As String = "配分処理"
    Public Const FORM_NAME_入出庫履歴 As String = "入出庫履歴"
    Public Const FORM_NAME_製品取込 As String = "製品取込"
    Public Const FORM_NAME_部品展開 As String = "部品展開"
    Public Const FORM_NAME_内装部品検索 As String = "内装部品検索"
    Public Const FORM_NAME_詳細表示 As String = "詳細表示"
    Public Const FORM_NAME_実棚一覧 As String = "実棚一覧"

    'その他
    Public Const FORM_NAME_宛名印刷 As String = "宛名印刷"
    Public Const FORM_NAME_商品リスト As String = "商品リスト"
    Public Const FORM_NAME_ラベル印刷 As String = "ラベル印刷"

    'マスタ
    '取引先一覧
    Public Const FORM_NAME_取引先一覧 As String = "取引先一覧"

    '取引先詳細
    Public Const FORM_NAME_取引先詳細 As String = "取引先詳細"

    '部門一覧
    Public Const FORM_NAME_部門一覧 As String = "部門一覧"

    '部門詳細
    Public Const FORM_NAME_部門詳細 As String = "部門詳細"

    'メインメニュー
    Public Const FORM_NAME_ﾒｲﾝﾒﾆｭｰ As String = "メインメニュー"

    '担当者一覧
    Public Const FORM_NAME_担当者一覧 As String = "担当者一覧"

    '担当者詳細
    Public Const FORM_NAME_担当者詳細 As String = "担当者詳細"

    Public Const FORM_NAME_商品マスタ As String = "商品マスタ"
    Public Const FORM_NAME_取引先マスタ As String = "取引先マスタ"
    Public Const FORM_NAME_配分率マスタ As String = "配分率マスタ"
    Public Const FORM_NAME_ﾋﾟｯｷﾝｸﾞ付加情報 As String = "ﾋﾟｯｷﾝｸﾞ付加情報"
    Public Const FORM_NAME_事業所マスタ As String = "事業所マスタ"
    Public Const FORM_NAME_部門マスタ As String = "部門マスタ"
    Public Const FORM_NAME_倉庫マスタ As String = "倉庫マスタ"
    Public Const FORM_NAME_担当者マスタ As String = "担当者マスタ"
    Public Const FORM_NAME_承認ルート As String = "承認ルート"
    Public Const FORM_NAME_管理マスタ As String = "管理マスタ"

#End Region

#Region "メッセージ共通"

    Public Const cgStrMsg共通_使用 As String = "使用"
    Public Const cgStrMsg共通_削除 As String = "削除"
    Public Const cgStrMsg共通_取扱なしに As String = "取扱なしに"
    Public Const cgStrMsg共通_CSV As String = "CSV"

#End Region

#Region "一覧画面の有効無効ﾌﾗｸﾞ(有効、無効、両方=2)"

    Public Enum ENU_FLG As Integer
        FLG_有効_値 = 1                '有効_値
        FLG_有効_CHECK = 0             '有効_CHECK
        FLG_無効_値 = 0                '無効_値
        FLG_無効_CHECK = 1             '無効_CHECK
        FLG_両方 = 2                   '両方
    End Enum

#End Region

#Region "処理名称"

    Public Const cgStrNew As String = "新规"
    Public Const cgStrUpdate As String = "修正"
    Public Const cgStrDelete As String = "删除"
    Public Const cgStrRef As String = "参照"
    Public Const cgStrInsert As String = "登録"
    Public Const cgStrCopy As String = "複写"
    Public Const cgStrRed As String = "赤伝"
    Public Const cgStrSelect As String = "選択"
    Public Const cgStrBakUpDB As String = "数据库备份"

#End Region

#Region "バック色"
    Public Shared ColorEnter As System.Drawing.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(153, Byte), Integer))

    Public Shared ColorActivateOnly As System.Drawing.Color = Color.Gainsboro
    Public Shared CommonSilver As System.Drawing.Color = System.Drawing.Color.FromArgb(CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer), CType(CType(190, Byte), Integer))
    Public Shared ColorL As System.Drawing.Color = Color.Brown
    Public Shared ColorM As System.Drawing.Color = Color.Brown
    Public Shared ColorP As System.Drawing.Color = Color.RoyalBlue
    Public Shared ColorH As System.Drawing.Color = Color.RoyalBlue
    Public Shared ColorTh As System.Drawing.Color = Color.RoyalBlue
    Public Shared ColorB As System.Drawing.Color = Color.Green
    Public Shared ColorC As System.Drawing.Color = Color.LightCoral
    Public Shared ColorS As System.Drawing.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
    Public Shared ColorBack As System.Drawing.Color = Color.White
    Public Shared Color小計 As System.Drawing.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))

#End Region

#Region "フリーワードのキー"

#End Region

#Region "採番コード"
    Public Const cStr採番コード_見積 = "01"

#End Region

#Region " Other"

#End Region

End Class