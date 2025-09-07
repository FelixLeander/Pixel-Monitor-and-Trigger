using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PixelControlledApi.Business;

internal class DeviceConnector
{
    private readonly RestClient _client = new();

    public DeviceConnector()
    {
    }

    public void Connect()
    {
        var restRequest = new RestRequest
        {
             Method = Method.Post,
        };

        foreach (var param in new List<(string Name, string Value)>()
        {
            ("token", ""), ("uid", ""), ("uname", ""), ("utoken", "")
        })
        restRequest.Parameters.AddParameter(Parameter.CreateParameter(param.Name, param.Value, ParameterType.HttpHeader));

        _client.Post();
    }
}
