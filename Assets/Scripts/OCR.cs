using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.ML.OnnxRuntime;
using Microsoft.ML.OnnxRuntime.Tensors;

/// <summary>
/// DEPRECATED
/// </summary>
public class OCR : MonoBehaviour
{
    //public InferenceSession session;

    //// Start is called before the first frame update
    //void Start()
    //{
    //    session = new InferenceSession(Application.dataPath + "/Models/craft.onnx"); //DEPRECATED - Tried porting CRAFT Pytorch to Onnx but didnt work. Reverted to pixel method.
    //}

    //// Update is called once per frame
    //void Update()
    //{

    //    float[] sourceData = new float[] { 0.1f, 0.1f, 0.1f, 0.1f };  // assume your data is loaded into a flat float array
    //    int[] dimensions = new int[] { 4 };    // and the dimensions of the input is stored here
    //    Tensor<float> t1 = new DenseTensor<float>(sourceData, dimensions);

    //    var inputs = new List<NamedOnnxValue>()
    //         {
    //            NamedOnnxValue.CreateFromTensor<float>("input.1", t1),
    //         };
    //    using (var results = session.Run(inputs))
    //    {
    //        // manipulate the results
    //        Debug.Log(results);
    //    }
    //}
}
