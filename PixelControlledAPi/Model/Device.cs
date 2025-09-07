using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelControlledApi.Model;

internal class Device
{
    private RestClient _restClient = new();
    private string _domain;
    private string _port;

    public Device(string domain = "", string port = "")
    {
        _domain = domain;
        _port = port;
    }

    private string GetUrl() => $"https://{_domain}:{_port}/command";

    internal void DoStuff()
    {

    }

    public void Connect(params KeyValuePair<string, string>[] parameter)
    {
        var restRequest = new RestRequest();

        var parameters = parameter.Select(p => Parameter.CreateParameter(p.Key, p.Value, ParameterType.HttpHeader)).ToList();
        restRequest.Parameters.AddParameters(parameters);

        //var response = _client.Post(restRequest);
    }
}
