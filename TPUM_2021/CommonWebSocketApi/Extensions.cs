using System;
using System.Text;

namespace TPUM_2021.CommonWebSocketApi
{
  internal static class Extensions
  {
    internal static ArraySegment<byte> GetArraySegment(this string message)
    {
      byte[] buffer = Encoding.UTF8.GetBytes(message);
      return new ArraySegment<byte>(buffer);
    }
  }
}