# hanekit's Warudo Plugin Mods

This library places the source code for the Plugin Mod for Warudo written by hanekit.  
这个库放置了 hanekit 编写的用于 Warudo 的插件模组 (Plugin Mod) 的源代码。

***Pull Requests* if you want to add localizations for other languages.**

## Plugin List

| Name                   | Practice Contents                                                                 |
|:---------------------- |:--------------------------------------------------------------------------------- |
| Moving Average Nodes   | - C# Basic                                                                        |
| Mouse Position Nodes   | - Static Text  `[Markdown]`                                                       |
| Slider Nodes           | - Slider<br />- Dynamic Text `[Markdown]` `WatchAll()` <br />- Button `[Trigger]` |
| Range Conditions Nodes | - C# Generic<br/>- `StructuredData`                                               |
| Rotating Anchor Asset  | - Basic Asset                                                                     |

V2 folders is a version refactored with generics, but they were not uploaded to Steam because of incompatibilities that could cause older versions of configured nodes to disappear.  
V2 文件夹是用泛型重构的版本，但是因为不兼容，可能导致旧版已配置的节点消失，所以并没有上传到 Steam。

## Nodes Table

| `Name`                                    | `Id`                                           |
|:----------------------------------------- |:---------------------------------------------- |
| `FloatMovingAverageNode`                  | `hanekit-c572faf8-5f42-43d8-83ed-71a37a3d0c34` |
| `Vector3MovingAverageNode`                | `hanekit-e1136b66-7bff-4ff7-ac07-b8459c595e0b` |
| `WarudoWindowSizeNode`                    | `hanekit-ba836451-2d4f-4de3-987e-0f71ba29dd21` |
| `WarudoWindowPositionNode`                | `hanekit-eaf572f3-b6bb-4901-a3f2-b3a06dfa74fc` |
| `MousePositionRelativeToWarudoCornerNode` | `hanekit-15402f55-0d83-4f75-8bd5-2a6d1b573ef6` |
| `MousePositionRelativeToWarudoCenterNode` | `hanekit-76f664f2-ab58-4408-bcdc-407ac9d98452` |
| `MousePositionRelativeToScreenNode`       | `hanekit-b1f59dd4-8e15-4e16-911d-ac19af203764` |
| `IntegerSliderNode`                       | `hanekit-25ccfb90-4f6d-4eea-9051-5c9e9b919668` |
| `FloatSliderNode`                         | `hanekit-3d303b22-109c-4eb7-acc8-9b24549d2297` |
| `Vector3LerpSliderNode`                   | `hanekit-c37b58b2-9567-422a-a947-d2c28e88304a` |
| `QuaternionLerpSliderNode`                | `hanekit-f6f98377-7e09-45b9-95dd-bd17da7a17bc` |
| `Vector3ComponentsSliderNode`             | `hanekit-31173a84-dbd5-4a9d-a82e-7a36e465defe` |
| `EulerAnglesComponentsSliderNode`         | `hanekit-7dc6622e-e4a4-4582-a9e5-850f610d690f` |
| `QuaternionComponentsSliderNode`          | `hanekit-4ab40d50-7cfd-4042-a7ea-0cc808dd0b4d` |
| `FloatRangeConditionsToIntegerNode`       | `hanekit-99bc73fc-7bdd-4df0-afdb-328d7e217d6e` |
| `FloatRangeConditionsToStringNode`        | `hanekit-4a748d39-04b9-48fe-acad-d143905ea8f0` |


