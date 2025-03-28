import axios from "axios";
import { useFormik } from "formik";
import React, { useState, useEffect } from "react";
import { useNavigate } from "react-router-dom";

function StafiCreate() {
  const [isLoading, setLoading] = useState(false);
  const navigate = useNavigate();

  const [kombetarjaList, setKombetarjaList] = useState([]);
  const [roliList, setRoliList] = useState([]);
 

  useEffect(() => {
               const fetchKombetarja = async () => {
                  try {
                      const response = await axios.get('http://localhost:5178/api/Kombetarja');
                      setKombetarjaList(response.data);
                   } catch (error) {
                       console.error('Failed to fetch kombetarja', error);
                   }
               };
               fetchKombetarja();
           }, []);
           useEffect(() => {
            const fetchRoli = async () => {
               try {
                   const response = await axios.get('http://localhost:5178/api/Roli');
                   setRoliList(response.data);
                } catch (error) {
                    console.error('Failed to fetch roli', error);
                }
            };
            fetchRoli();
        }, []);
  const myFormik = useFormik({
    initialValues: {
      emri: "",
      mbiemri: "",
      pozita: "",
      paga: "",
      email: "",
      telefoni: "",
      kombetarjaID: "",
      roliID:""

    },

    // Validating Forms while entering the data
    validate: (values) => {
      let errors = {};

      if (!values.emri) {
        errors.emri = "Ju lutem vendosni emrin";
      } else if (values.emri.length < 3) {
        errors.emri = "Emri duhet të jetë së paku 3 shkronja";
      } else if (values.emri.length > 20) {
        errors.emri = "Emri nuk mund të jetë më shumë se 20 shkronja";
      }

      if (!values.mbiemri) {
        errors.mbiemri = "Ju lutem vendosni mbiemrin";
      } else if (values.mbiemri.length < 3) {
        errors.mbiemri = "Mbiemri duhet të jetë së paku 3 shkronja";
      } else if (values.mbiemri.length > 20) {
        errors.mbiemri = "Mbiemri nuk mund të jetë më shumë se 20 shkronja";
      }


      if (!values.paga) {
        errors.paga = "Ju lutem vendosni pagën";
      } else if (isNaN(values.paga)) {
        errors.paga = "Paga duhet të jetë një numër";
      } else if (parseInt(values.paga) <= 0) {
        errors.paga = "Paga duhet të jetë më e madhe se zero";
      }

      if (!values.email) {
        errors.email = "Ju lutem vendosni adresën email";
      } else if (!/^\S+@\S+\.\S+$/.test(values.email)) {
        errors.email = "Adresa email nuk është valide";
      }

      if (!values.telefoni) {
        errors.telefoni = "Ju lutem vendosni numrin e telefonit";
      }

      return errors;
    },

    onSubmit: async values => {
      try {
          setLoading(true);
          const payload = {
              ...values,
              kombetarjaID: parseInt(values.kombetarjaID) // Ensure kombetarjaID is sent as an integer
          };
          await axios.post("http://localhost:5178/api/Stafi", payload);
          navigate("/portal/stafi-list");
      } catch (error) {
          console.error("Error during form submission:", error);
          alert("Failed to create Kombetarja: " + error.message);
          setLoading(false);
      }
  }
  });

  return (
    <div className="container">
      <form onSubmit={myFormik.handleSubmit}>
        <div className="row">
          <div className="col-lg-6">
            <label>Emri</label>
            <input
              name="emri"
              value={myFormik.values.emri}
              onChange={myFormik.handleChange}
              type={"text"}
              className={`form-control ${
                myFormik.errors.emri ? "is-invalid" : ""
              } `}
            />
            <span style={{ color: "red" }}>{myFormik.errors.emri}</span>
          </div>

          <div className="col-lg-6">
            <label>Mbiemri</label>
            <input
              name="mbiemri"
              value={myFormik.values.mbiemri}
              onChange={myFormik.handleChange}
              type={"text"}
              className={`form-control ${
                myFormik.errors.mbiemri ? "is-invalid" : ""
              } `}
            />
            <span style={{ color: "red" }}>{myFormik.errors.mbiemri}</span>
          </div>


          <div className="col-lg-6">
            <label>Paga</label>
            <input
              name="paga"
              value={myFormik.values.paga}
              onChange={myFormik.handleChange}
              type={"number"}
              className={`form-control ${
                myFormik.errors.paga ? "is-invalid" : ""
              } `}
            />
            <span style={{ color: "red" }}>{myFormik.errors.paga}</span>
          </div>

          <div className="col-lg-6">
            <label>Email</label>
            <input
              name="email"
              value={myFormik.values.email}
              onChange={myFormik.handleChange}
              type={"email"}
              className={`form-control ${
                myFormik.errors.email ? "is-invalid" : ""
              } `}
            />
            <span style={{ color: "red" }}>{myFormik.errors.email}</span>
          </div>

          <div className="col-lg-6">
            <label>Telefoni</label>
            <input
              name="telefoni"
              value={myFormik.values.telefoni}
              onChange={myFormik.handleChange}
              type={"tel"}
              className={`form-control ${
                myFormik.errors.telefoni ? "is-invalid" : ""
              } `}
            />
            <span style={{ color: "red" }}>{myFormik.errors.telefoni}</span>
          </div>

          <div className='form-group'>
                     <label htmlFor='roliID'>Pozita</label>
                     <select
                         id='roliID'
                         name='roliID'
                         onChange={myFormik.handleChange}
                         value={myFormik.values.roliID}
                         className={`form-control ${myFormik.errors.roliID ? 'is-invalid' : ''}`}
                     >
                         <option value="">Select Pozita</option>
                         {roliList.map(roli => (
                             <option key={roli.id} value={roli.id}>
                                 {roli.emri}
                             </option>
                         ))}
                     </select>
                     {myFormik.errors.kombetarjaID ? <div className='invalid-feedback'>{myFormik.errors.kombetarjaID}</div> : null}
                 </div>

          <div className='form-group'>
                     <label htmlFor='kombetarjaID'>Kombetarja</label>
                     <select
                         id='kombetarjaID'
                         name='kombetarjaID'
                         onChange={myFormik.handleChange}
                         value={myFormik.values.kombetarjaID}
                         className={`form-control ${myFormik.errors.kombetarjaID ? 'is-invalid' : ''}`}
                     >
                         <option value="">Select Kombetarja</option>
                         {kombetarjaList.map(kombetarja => (
                             <option key={kombetarja.id} value={kombetarja.id}>
                                 {kombetarja.emri}
                             </option>
                         ))}
                     </select>
                     {myFormik.errors.kombetarjaID ? <div className='invalid-feedback'>{myFormik.errors.kombetarjaID}</div> : null}
                 </div>

          <div className="col-lg-4 mt-3">
            <input
              disabled={isLoading}
              type="submit"
              value={isLoading ? "Submitting..." : "Create"}
              className=" btn btn-primary"
            />
          </div>
        </div>
      </form>
      {/* {JSON.stringify(myFormik.values)} */}
    </div>
  );
}

export default StafiCreate;
