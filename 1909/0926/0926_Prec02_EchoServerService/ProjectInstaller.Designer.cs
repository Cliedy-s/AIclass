namespace _0926_Prec02_EchoServerService
{
    partial class ProjectInstaller
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Alambana_EchoServerProcess = new System.ServiceProcess.ServiceProcessInstaller();
            this.Alambana_EchoServerInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // Alambana_EchoServerProcess
            // 
            this.Alambana_EchoServerProcess.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.Alambana_EchoServerProcess.Password = null;
            this.Alambana_EchoServerProcess.Username = null;
            // 
            // Alambana_EchoServerInstaller
            // 
            this.Alambana_EchoServerInstaller.Description = "Alambana_EchoServer";
            this.Alambana_EchoServerInstaller.DisplayName = "Alambana_EchoServer";
            this.Alambana_EchoServerInstaller.ServiceName = "Alambana_EchoServer";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.Alambana_EchoServerProcess,
            this.Alambana_EchoServerInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller Alambana_EchoServerProcess;
        private System.ServiceProcess.ServiceInstaller Alambana_EchoServerInstaller;
    }
}