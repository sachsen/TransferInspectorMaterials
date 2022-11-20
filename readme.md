fbx→VRChat→VRMの時にVRMConverter for VRChatではmeta情報のコピー機能はあるのにmaterialのコピーが無かったんで自分用に作りました

50行しか書いてないので、大したものでは無いです。動作を期待しないでください。このプログラムについて何の責任も負いません。

## TransferInspectorMaterials
SkinnedMeshRendererのマテリアルのリストを別のSkinnedMeshRendererにセットします。

コピー元と先でリストの要素数が異なれば、少ない方を基準に先頭からコピーします。

マテリアル自身はコピーしません。


## Install
Unityの適当な場所にEditorフォルダを作ってその下に入れたら動きます

試してないのでわからないですが、もしかしたらフォルダに入れなくても動くかもです。

## How to use

1. 上のツールバー→Tools→Open Inspector Material Transfer Windowでwindowを開きます。
2. sizeのところにコピーするSkinnedMeshRendererの数を入力します。
3. sourceにコピー元のSkinnedMeshRendererを、Destinationにコピー先のSkinnedMeshRendererを入れます。
4. Copy!ボタンを押すと、コピー元のマテリアルリストがコピー先にもセットされます。

