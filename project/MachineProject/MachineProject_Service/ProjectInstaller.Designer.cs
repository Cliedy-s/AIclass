﻿namespace MachineProject_Service
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
            this.MachineServiceProcessInstraller = new System.ServiceProcess.ServiceProcessInstaller();
            this.MachineServiceInstaller = new System.ServiceProcess.ServiceInstaller();
            // 
            // MachineServiceProcessInstraller
            // 
            this.MachineServiceProcessInstraller.Account = System.ServiceProcess.ServiceAccount.LocalSystem;
            this.MachineServiceProcessInstraller.Password = null;
            this.MachineServiceProcessInstraller.Username = null;
            // 
            // MachineServiceInstaller
            // 
            this.MachineServiceInstaller.Description = "MachineService";
            this.MachineServiceInstaller.DisplayName = "MachineService";
            this.MachineServiceInstaller.ServiceName = "MachineService";
            // 
            // ProjectInstaller
            // 
            this.Installers.AddRange(new System.Configuration.Install.Installer[] {
            this.MachineServiceProcessInstraller,
            this.MachineServiceInstaller});

        }

        #endregion

        private System.ServiceProcess.ServiceProcessInstaller MachineServiceProcessInstraller;
        private System.ServiceProcess.ServiceInstaller MachineServiceInstaller;
    }
}