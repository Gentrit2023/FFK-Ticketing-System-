import axios from 'axios';
import { useFormik } from 'formik';
import React, { useEffect, useState } from 'react'
import { useNavigate, useParams } from 'react-router-dom'

function LojtaretEdit() {
    const params = useParams();
    const [kombetarjaList, setKombetarjaList] = useState([]);
    const [isLoading, setLoading] = useState(false);
    const navigate = useNavigate();
    const { id } = useParams();
    useEffect(() => {
        const fetchKombetarja = async () => {
          try {
            const response = await axios.get("http://localhost:5178/api/Kombetarja");
            setKombetarjaList(response.data);
          } catch (error) {
            console.error('Error fetching Kombetarja data:', error);
          }
        };
    
        const fetchLojtaret = async () => {
          try {
            const response = await axios.get(`http://localhost:5178/api/Lojtaret/${params.id}`);
            myFormik.setValues(response.data);
          } catch (error) {
            console.error('Error fetching Kombetarja data:', error);
          }
        };
    
        fetchKombetarja();
        fetchLojtaret();
      }, [id]);
 

    const myFormik = useFormik({
        initialValues: {
            emri: "",
            mbiemri: "",
            mosha: "",
            pozicioni: "",
            gola: "",
            asiste: "",
            nrFaneles:"",
            kombetarjaID: ""
         
        },
        // Validating Forms while entering the data
        validate: values => {
            let errors = {};
            if (!values.emri) {
                errors.emri = "Ju lutem shkruani emrin e lojtarit";
            }
            if (!values.mbiemri) {
                errors.mbiemri = "Ju lutem shkruani mbiemrin e lojtarit";
            }
            if (!values.mosha) {
                errors.mosha = "Ju lutem shkruani moshen e lojtarit";
            }
            if (!values.pozicioni) {
                errors.pozicioni = "Ju lutem shkruani pozicionin e lojtarit";
            }
            if (!values.gola) {
                errors.gola = "Ju lutem shkruani golat e lojtarit";
            }
            if (!values.asiste) {
                errors.asiste = "Ju lutem shkruani asistet e lojtarit";
            }
            if (!values.gola) {
                errors.gola = "Ju lutem shkruani golat e lojtarit";
            }
            if (!values.nrFaneles) {
                errors.nrFaneles = "Ju lutem shkruani nrFaneles se lojtarit";
            }
            if (!values.kombetarjaID) {
                errors.kombetarjaID = "Ju lutem zgjidhni një kombetare";
            }

            return errors;
        },

        onSubmit: async (values) => {
            try { 
                setLoading(true);
                await axios.put(`http://localhost:5178/api/Lojtaret/${params.id}`, values);
                setLoading(false);
                navigate("/portal/lojtaret-list")
            } catch (error) {
                console.log(error);
                setLoading(false);
            }
        }
    })
    return (
        <>
            <h3>LOJTARI Edit : {params.id} </h3>
            <div className='container'>
                <form onSubmit={myFormik.handleSubmit}>
                    <div className='row'>

                        <div className="col-lg-6">
                            <label>Emri</label>
                            <input name='emri' value={myFormik.values.emri} onChange={myFormik.handleChange} type={"text"}
                                className={`form-control ${myFormik.errors.emri ? "is-invalid" : ""} `} />
                            <span style={{ color: "red" }}>{myFormik.errors.emri}</span>
                        </div>

                        <div className="col-lg-6">
                            <label>Mbiemri</label>
                            <input name='mbiemri' value={myFormik.values.mbiemri} onChange={myFormik.handleChange} type={"text"}
                                className={`form-control ${myFormik.errors.mbiemri ? "is-invalid" : ""} `} />
                            <span style={{ color: "red" }}>{myFormik.errors.mbiemri}</span>
                        </div>

                        <div className="col-lg-6">
                            <label>Mosha</label>
                            <input name='mosha' value={myFormik.values.mosha} onChange={myFormik.handleChange} type={"number"}
                                className={`form-control ${myFormik.errors.mosha ? "is-invalid" : ""} `} />
                            <span style={{ color: "red" }}>{myFormik.errors.mosha}</span>
                        </div>

                        <div className="col-lg-6">
                            <label>Pozicioni</label>
                            <input name='pozicioni' value={myFormik.values.pozicioni} onChange={myFormik.handleChange} type={"text"}
                                className={`form-control ${myFormik.errors.pozicioni ? "is-invalid" : ""} `} />
                            <span style={{ color: "red" }}>{myFormik.errors.pozicioni}</span>
                        </div>

                        <div className="col-lg-6">
                            <label>Gola</label>
                            <input name='gola' value={myFormik.values.gola} onChange={myFormik.handleChange} type={"number"}
                                className={`form-control ${myFormik.errors.gola ? "is-invalid" : ""} `} />
                            <span style={{ color: "red" }}>{myFormik.errors.gola}</span>
                        </div>

                        <div className="col-lg-6">
                            <label>Asiste</label>
                            <input name='asiste' value={myFormik.values.asiste} onChange={myFormik.handleChange} type={"number"}
                                className={`form-control ${myFormik.errors.asiste ? "is-invalid" : ""} `} />
                            <span style={{ color: "red" }}>{myFormik.errors.asiste}</span>
                        </div>

                        <div className="col-lg-6">
                            <label>Numri Faneles</label>
                            <input name='nrFaneles' value={myFormik.values.nrFaneles} onChange={myFormik.handleChange} type={"number"}
                                className={`form-control ${myFormik.errors.nrFaneles ? "is-invalid" : ""} `} />
                            <span style={{ color: "red" }}>{myFormik.errors.nrFaneles}</span>
                        </div>





                        

                       
                    
       

                        <div className='col-lg-4 mt-3'>
                            <input disabled={isLoading} type="submit" value={isLoading ? "Updating..." : "Update"} className=' btn btn-primary' />
                        </div>
                    </div>
                </form>
                {/* {JSON.stringify(myFormik.values)} */}
            </div>
        </>


    )
}

export default LojtaretEdit
