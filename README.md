# VR_Infographics
ABC2017 SpringのVRハンズオン用に作成したものです。

## 使用方法
Unity標準アセットやGoogle VR SDK等は含まれていないので、プロジェクトをUnityで開いたら次の手順で必要なものをインポートしてください。

1. メインメニューの［Assets］を選択します。それから［Import Package］→［ParticleSystems］の順に操作します。
2. インポート可能なすべてのものをリスト表示したインポートダイアログがポップアップするので［Import］をクリックします。
3. Projectパネルの`Assets`を選択し、Infographicsという名前のシーン（Unityのロゴがアイコンになっているもの）をダブルクリックして開くとSceneビューにオブジェクトが表示されます。


### ビルド方法
AndroidおよびiOSで動かすCardboard用にビルドする場合は、SDK等の他のパッケージは不要です。

1. メインメニューの［File］→［Build  Settings...］を選択します。
2. ［Scenes In Build］に現在のシーンがない場合は、［Add Open Scenes］をクリックします。
3. 左側のPlatformの一覧から［Android］または［iOS］を選択して、［Switch Platform］をクリックします。
4. それから、［Player Settings...］をクリックします。InspectorパネルにPlayer Settingsが表示されます。
5. ［Other Settings］の中にある［Virtual Reality Supported］のチェックをONにします 。
6. [図1](#fig_b_2)のように［Virtual Reality Supported］チェックボックスの下に［Cardboard］もしくは［Daydream］の文字が表示されていることも確認します。もし表示されていなければ［＋］ボタンを押して選択肢の中から追加します。（iOSの場合は［Cardboard］のみが表示されます。）
7. ［Other Settings］→［Identification］→［Bundle Identifier］にcom.YourName.VRisAwesomeなどのように有効な文字列を入力します。
8. ［Build And Run］を押すと、ビルドして端末に転送されてアプリが起動します。
9. Cardboardに端末をセットして見てみましょう。

![図1 Virtual Reality Supportedのチェックボックス](https://raw.githubusercontent.com/wiki/oreilly-japan/unity-virtual-reality-projects-ja/images/ch13b/vr_support_checkbox.png)

<a name="fig_b_2">図1</a> Virtual Reality Supportedのチェックボックス

### Unityのエディターでプレビューする方法
Unityのエディターのプレビュー機能でカメラの方向を動かして確認する場合はGoogle VR SDK for UnityのSDKが必要です。

1. ウェブブラウザで<https://developers.google.com/vr/unity/download>を開いて、Google VR SDK for Unityをダウンロードします。
2. Unityのメインメニューの［Assets］から［Import Package］→［Custom Package...］を選択します。
3. ダウンロードした`GoogleVRForUnity.unitypackage`というファイルを見つけて選択します。
4. すべてのアセットにチェックが付いていることを確認して、［Import］をクリックします。
5. ［Project］ウィンドウの /Assets/GoogleVR/Prefabs の下にある GvrEditorEmulator を［Hierarchy］ウィンドウにドラッグ＆ドロップします。
6. ［Play］ボタンを押します。
7. alt キーを押しながらマウスカーソルを動かすと見る方向が変わります。



