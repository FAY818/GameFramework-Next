namespace GameFramework.Resource
{
    /// <summary>
    /// 资源系统日志处理
    /// </summary>
    internal class ResourceLogger : YooAsset.ILogger
    {
        public void Log(string message)
        {
            UnityGameFramework.Runtime.Log.Info(message);
        }

        public void Warning(string message)
        {
            UnityGameFramework.Runtime.Log.Warning(message);
        }

        public void Error(string message)
        {
            UnityGameFramework.Runtime.Log.Error(message);
        }

        public void Exception(System.Exception exception)
        {
            UnityGameFramework.Runtime.Log.Fatal(exception.Message);
        }
    }
}