
namespace PCF_CONSOLE.Helper
{
    public class Comandos
    {
        public class Cmd
        {
            private const string MSBUILD_SCRIPT_FILE_LOCATION = "msbuild.ps1";


        
            public static string ChangeDirectory(string pPath)
            {
                return $"cd \"{pPath}\"";
            }

           
            public static string MakeDirectory(string pFolderName)
            {
                return $"mkdir \"{pFolderName}\"";
            }

            /// <summary>
            /// rmdir /s/q "folderName"
            /// </summary>
            /// <param name="folderName"></param>
            /// <returns></returns>
            public static string RemoveDirectory(string pFolderName)
            {
                return $"rmdir /s/q \"{pFolderName}\"";
            }

            public static string FindMsBuild()
            {
                var fullPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Name + "\\" + MSBUILD_SCRIPT_FILE_LOCATION;

                return $"powershell \"& \"\"" + fullPath + "\"\"\"";
            }
        }

        public class ComandoPac
        {
            /// <summary>
            /// pac pcf init --namespace controlNamespace --name controlName --template controlTemplate.ToLower()
            /// </summary>
            /// <param name="controlNamespace"></param>
            /// <param name="controlName"></param>
            /// <param name="controlTemplate"></param>
            /// <returns></returns>
            public static string PacPcfInit(string controlNamespace, string controlName, string controlTemplate)
            {
                return $"pac pcf init --namespace {controlNamespace} --name {controlName} --template {controlTemplate.ToLower()}";
            }

            /// <summary>
            /// pac solution init --publisher-name publisherName --publisher-prefix customizationPrefix
            /// </summary>
            /// <param name="publisherName"></param>
            /// <param name="customizationPrefix"></param>
            /// <returns></returns>
            public static string PacSolutionInit(string publisherName, string customizationPrefix)
            {
                return $"pac solution init --publisher-name {publisherName} --publisher-prefix {customizationPrefix}";
            }

            /// <summary>
            /// pac solution add-reference --path "path"
            /// </summary>
            /// <param name="path"></param>
            /// <returns></returns>
            public static string PacSolutionAddReference(string path)
            {
                return $"pac solution add-reference --path \"{path}\"";
            }

            /// <summary>
            /// pac install latest
            /// </summary>
            /// <returns></returns>
            public static string PacInstallLatest()
            {
                return $"pac install latest";
            }

            /// <summary>
            /// pac use
            /// </summary>
            /// <returns></returns>
            public static string PacUse()
            {
                return $"pac use";
            }

            /// <summary>
            /// pac
            /// </summary>
            /// <returns></returns>
            public static string PacCheck()
            {
                return $"pac";
            }

            /// <summary>
            /// pac auth create --url <https://xyz.crm.dynamics.com>
            /// </summary>
            /// <param name="url">CDS Environment Url</param>
            /// <returns></returns>
            public static string PacCreateProfile(string url)
            {
                return $"pac auth create --url {url}";
            }

            /// <summary>
            /// pac auth list
            /// </summary>
            /// <returns></returns>
            public static string PacListProfiles()
            {
                return $"pac auth list";
            }

            /// <summary>
            /// pac auth delete --index <indexoftheprofile>
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public static string PacDeleteProfile(int index)
            {
                return $"pac auth delete --index {index}";
            }

            /// <summary>
            /// pac auth select --index <indexoftheactiveprofile>
            /// </summary>
            /// <param name="index"></param>
            /// <returns></returns>
            public static string PacSwitchCurrentProfile(int index)
            {
                return $"pac auth select --index {index}";
            }

            /// <summary>
            /// pac pcf push --publisher-prefix <yourpublisherprefix>
            /// </summary>
            /// <param name="publisherPrefix"></param>
            /// <returns></returns>
            public static string PacDeployWithoutSolution(string publisherPrefix)
            {
                return $"pac pcf push --publisher-prefix {publisherPrefix}";
            }

            /// <summary>
            /// pac org who
            /// </summary>
            /// <returns></returns>
            public static string PacOrgDetails()
            {
                return $"pac org who";
            }
        }

        public class ComandoNpm
        {
            /// <summary>
            /// npm version
            /// </summary>
            /// <returns></returns>
            public static string Version()
            {
                return $"npm version";
            }

            /// <summary>
            /// npm install
            /// </summary>
            /// <returns></returns>
            public static string Install()
            {
                return $"npm install";
            }

            /// <summary>
            /// npm run build
            /// </summary>
            /// <returns></returns>
            public static string RunBuild()
            {
                return $"npm run build";
            }

            /// <summary>
            /// npm start
            /// </summary>
            /// <returns></returns>
            public static string Start()
            {
                return $"npm start";
            }

            /// <summary>
            /// npm start watch
            /// </summary>
            /// <returns></returns>
            public static string StartWatch()
            {
                return $"npm start watch";
            }
        }

        public class ComandoMsbuild
        {
            /// <summary>
            /// msbuild
            /// </summary>
            /// <returns></returns>
            public static string Build(string projectPath = "")
            {
                return $"./msbuild.exe \"{projectPath}\"";
            }

            /// <summary>
            /// msbuild /t:restore
            /// </summary>
            /// <returns></returns>
            public static string Restore(string projectPath = "")
            {
                return $"./msbuild.exe /t:restore \"{projectPath}\"";
            }

            /// <summary>
            /// msbuild /t:rebuild
            /// </summary>
            /// <returns></returns>
            public static string Rebuild(string projectPath = "")
            {
                return $"./msbuild.exe /t:rebuild \"{projectPath}\"";
            }

            /// <summary>
            /// msbuild /p:configuration=Release
            /// </summary>
            /// <returns></returns>
            public static string BuildRelease(string projectPath = "")
            {
                return $"./msbuild.exe /p:configuration=Release \"{projectPath}\"";
            }

            /// <summary>
            /// msbuild /t:rebuild /p:configuration=Release
            /// </summary>
            /// <returns></returns>
            public static string RebuildRelease(string projectPath = "")
            {
                return $"./msbuild.exe /t:rebuild /p:configuration=Release \"{projectPath}\"";
            }
        }

    }
}
