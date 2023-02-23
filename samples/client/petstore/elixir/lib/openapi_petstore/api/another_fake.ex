# NOTE: This file is auto generated by OpenAPI Generator 6.5.0-SNAPSHOT (https://openapi-generator.tech).
# Do not edit this file manually.

defmodule OpenapiPetstore.Api.AnotherFake do
  @moduledoc """
  API calls for all endpoints tagged `AnotherFake`.
  """

  alias OpenapiPetstore.Connection
  import OpenapiPetstore.RequestBuilder

  @doc """
  To test special tags
  To test special tags and operation ID starting with number

  ### Parameters

  - `connection` (OpenapiPetstore.Connection): Connection to server
  - `client` (Client): client model
  - `opts` (keyword): Optional parameters

  ### Returns

  - `{:ok, OpenapiPetstore.Model.Client.t}` on success
  - `{:error, Tesla.Env.t}` on failure
  """
  @spec call_123_test_special_tags(Tesla.Env.client, OpenapiPetstore.Model.Client.t, keyword()) :: {:ok, OpenapiPetstore.Model.Client.t} | {:error, Tesla.Env.t}
  def call_123_test_special_tags(connection, client, _opts \\ []) do
    request =
      %{}
      |> method(:patch)
      |> url("/another-fake/dummy")
      |> add_param(:body, :body, client)
      |> Enum.into([])

    connection
    |> Connection.request(request)
    |> evaluate_response([
      {200, %OpenapiPetstore.Model.Client{}}
    ])
  end
end
