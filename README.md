嘻嘻15.0
一个基于 VB.NET 的多模态机器人 / 人工智能模拟系统，集成了视觉、听觉、语音合成、动作控制和 3D 可视化。项目使用 Windows Forms 构建，依赖 Emgu.CV（OpenCV）和 Managed DirectX，通过串口与外部硬件通信，试图模拟一个具有“眼、耳、舌、身、意、鼻”的简单生命体。

⚠️ 注意：本项目为实验性代码，包含大量硬编码参数和未完成的功能，主要用于学习和研究目的。

✨ 功能特性
模块	说明
眼	使用两个摄像头（索引 0 和 1）实时采集图像，进行模板匹配、目标跟踪、边缘检测等计算机视觉处理。
耳	通过 DirectSound 捕获双通道音频，进行波形分析、FFT 变换，提取频率和幅度信息。
舌	使用 DirectSound 缓冲区合成并播放音频，可生成正弦波、调制波形，支持实时参数调整。
身	通过串口（默认 COM3，115200 波特率）发送舵机控制指令，实现头部、手臂等动作。
意	核心思维模块，维护 3D 空间中的骨骼模型、观察点、运动学计算，并驱动 Direct3D 调试窗口。
鼻	预留的嗅觉模块（目前仅定义变量）。
调试界面	包含大量 TrackBar、Button、PictureBox，用于实时调节参数、显示图像和波形。
🖥️ 系统要求
操作系统：Windows 7 / 8 / 10 / 11 或 Windows Server 2012 及以上

运行时：.NET Framework 4.0 Client Profile 或更高版本

硬件：

摄像头 × 2（代码中固定使用索引 0 和 1，可在 眼.vb 中修改）

麦克风 / 音频输入设备（双通道）

音频输出设备

串口设备（可选，用于动作控制，默认 COM3）

其他：DirectX 9.0c 运行时（Managed DirectX 需要）

📦 依赖项
项目引用了以下第三方库，请确保它们存在于 ..\DirectX链接库\ 目录下（相对于 .vbproj 文件）：

库	版本	用途
Emgu.CV.dll	3.0.0.2157	计算机视觉
Emgu.CV.ML.dll	3.0.0.2157	机器学习
Emgu.CV.UI.dll	3.0.0.2157	图像显示
Emgu.Util.dll	3.0.0.2157	Emgu 工具
Microsoft.DirectX.dll	-	Managed DirectX
Microsoft.DirectX.Direct3D.dll	-	3D 渲染
Microsoft.DirectX.Direct3DX.dll	-	D3DX 辅助
microsoft.directx.Directsound.dll	-	音频捕获与播放
提示：Emgu.CV 还需要对应的 OpenCV 原生 DLL（如 opencv_core300.dll、opencv_imgproc300.dll 等），请将它们复制到输出目录（bin\Debug\ 或 bin\Release\）。

🚀 构建与运行
克隆仓库

bash
git clone https://github.com/yourname/xixi15.0.git
cd xixi15.0
准备依赖库

将上述 DLL 放入 ..\DirectX链接库\ 目录（或修改项目引用路径）。

确保 OpenCV 原生 DLL 位于输出目录。

使用 Visual Studio 打开项目

打开 嘻嘻15.0.vbproj（需要 Visual Studio 2010 或更高版本，支持 VB.NET）。

检查所有引用是否正常（红色感叹号表示缺失）。

编译

选择 Debug | x86 或 Release | x86，然后生成解决方案。

运行前配置

修改 身.vb 中的串口号（默认 COM3）以匹配你的硬件。

修改 眼.vb 中的摄像头索引（默认 0 和 1）。

确保音频设备可用。

启动

运行 嘻嘻15.0.exe，主窗口标题为“嘻嘻15.0”。

📁 项目结构
text
嘻嘻15.0/
├── App.config                  # 应用程序配置（.NET 4.0 旧版激活策略）
├── 公用函数_模块.vb            # 通用函数与常量
├── 意.vb                       # 核心思维、3D 数学、Direct3D 调试窗口
├── 眼.vb                       # 双摄像头采集与图像处理
├── 耳.vb                       # 音频捕获、FFT 分析
├── 舌.vb                       # 音频合成与播放
├── 身.vb                       # 串口通信、动作控制
├── 鼻.vb                       # 嗅觉占位模块
├── 调试窗体.vb                 # 主窗体逻辑
├── 调试窗体.Designer.vb        # 主窗体界面设计器代码
└── 嘻嘻15.0.vbproj             # VB.NET 项目文件
⚙️ 配置说明
串口（身.vb）
vb
Private 行___ As New System.IO.Ports.SerialPort With {
    .PortName = "COM3",
    .BaudRate = 115200,
    .DataBits = 8,
    .StopBits = 1,
    .Parity = Ports.Parity.None
}
修改 .PortName 为实际串口。

波特率默认 115200。

摄像头（眼.vb）
vb
ley = New Capture(0)   ' 左眼
rey = New Capture(1)   ' 右眼
如果只有一个摄像头，可改为相同索引或注释掉其中一个。

音频设备（耳.vb / 舌.vb）
使用 CaptureDevicesCollection 和 DevicesCollection 枚举设备，默认取索引 1 的设备。

可在代码中调整。

📝 注意事项
Managed DirectX 已过时：项目依赖的 Microsoft.DirectX 系列 DLL 来自 DirectX SDK (June 2010) 或更早版本。在较新的 Windows 上可能需要手动注册或安装 DirectX 9.0c 运行时。

Emgu.CV 版本：项目使用 3.0.0.2157，对应 OpenCV 3.0。请勿混用其他版本，否则可能出现 DllNotFoundException。

x86 平台：项目固定为 x86，因为 Managed DirectX 和某些 OpenCV DLL 仅提供 32 位版本。

性能：程序会创建多个线程（摄像头、音频、串口、渲染），CPU 占用较高，建议在性能较好的机器上运行。

安全：串口控制会直接驱动硬件，请确保指令与你的设备匹配，避免损坏。

📄 许可证
本项目未指定开源许可证。请尊重原作者的意图，并遵守所有依赖库（Emgu.CV、DirectX 等）的许可协议。

🙏 致谢
Emgu CV - OpenCV 的 .NET 封装

Microsoft DirectX - 3D 渲染与音频

所有为这个实验项目提供灵感的人

“嘻嘻” —— 一个试图用代码模拟生命的尝试。

捐赠 BTC: 13SongiriQuWoFhoimsVS21CyaTxozKBVA
