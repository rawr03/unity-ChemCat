using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Unity.RemoteConfig;
//using Unity.Services.Core;
//using System.Configuration;
//using System.Threading.Tasks;
//using Unity.Services.RemoteConfig;
//using System.Configuration;
using Unity.Services.RemoteConfig;

public class RConfigTest : MonoBehaviour
{
    /*
    public static RConfigTest Instance { get; private set; }
    public bool test = false;

    public struct userAttributes
    {
        public bool test;
    }

    public struct appAttributes
    {

    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    async void Start()
    {
        ConfigManager.FetchConfig<userAttributes, appAttributes>(uaStruct, new appAttributes(){ });
    }

    
    async Task InitializeRemoteConfig()
    {
        await UnityServices.InitializeAsync();

        if(!Ana)
    }*/

    /*
    //First Try
    //public static class ConfigManager;
    
    public struct userAttributes { }
    public struct appAttributes { }

    public bool test = false;
    

    // Start is called before the first frame update
    
    void Awake()
    {
        ConfigManager.FetchCompleted += SetTrue;
        ConfigManager.FetchConfig<userAttributes, appAttributes>(new userAttributes(), new appAttributes());
        //ConfigManagerImpl.FetchCompleted += SetTrue;
        //ConfigurationManager.FetchCompleted += SetTrue;
    }

    void SetTrue(ConfigResponse response)
    {
        test = appConfig.GetBool("testIsTrue");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDestroy()
    {
        ConfigManager.FetchCompleted -= SetTrue;
    }*/
}
