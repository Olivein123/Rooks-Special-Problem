import './RetentionRate.css'
import * as React from 'react';
import MuiNavBar from '../components/NavBar/MuiNavBar';
import Typography from '@mui/material/Typography';
import TextField from '@mui/material/TextField';
import InputLabel from '@mui/material/InputLabel';
import MenuItem from '@mui/material/MenuItem';
import FormControl from '@mui/material/FormControl';
import Select, { SelectChangeEvent } from '@mui/material/Select';
import axios from 'axios';

const RetentionRate = () => {
    const [address, setAdress] = React.useState('');
    const [fundSource, setFundSource] = React.useState('');
    const [fundType, setFundType] = React.useState('');
    const [hasJob, setHasJob] = React.useState('');
    const [parentsIncome, setParentsIncome] = React.useState('');
    const [siblings, setSiblings] = React.useState('');
    const [dependentSiblings, setDependentSiblings] = React.useState('');
    const [strand, setStrand] = React.useState('');
    const [joinedScienceHigh, setJoinedScienceHigh] = React.useState('');
    const [withHonors, setWithHonors] = React.useState('');
    const [englishGradeRange, setEnglishGradeRange] = React.useState('');
    const [mathGradeRange, setMathGradeRange] = React.useState('');
    const [scienceGradeRange, setScienceGradeRange] = React.useState('');
    const [gpa, setGpa] = React.useState('');
    const [course, setCourse] = React.useState('');
    const [professor, setProfessor] = React.useState('');
    const [modeOfDelivery, setModeOfDelivery] = React.useState('');
    const [hasScholarship, setHasScholarship] = React.useState('');
    const [isInCebu, setIsInCebu] = React.useState('');
    const [CurrentStayingPlace, setCurrentStayingPlace] = React.useState('');
    const [HasEnoughStudySpace, setHasEnoughStudySpace] = React.useState('');
    const [ModeTransportGoingHome, setModeTransportGoingHome] = React.useState('');
    const [CommuteCountGoingHome, setCommuteCountGoingHome] = React.useState('');
    const [CommuteDurationGoingHome, setCommuteDurationGoingHome] = React.useState('');
    const [ModeTransportGoingSchool, setModeTransportGoingSchool] = React.useState('');
    const [CommuteCountGoingSchool, setCommuteCountGoingSchool] = React.useState('');
    const [CommuteDurationGoingSchool, setCommuteDurationGoingSchool] = React.useState('');
    const [HasDevice, setHasDevice] = React.useState('');
    const [predictedLabel, setPredictedLabel] = React.useState(null);
    const [score, setScore] = React.useState(null);

    const handleChangeAddress = (event) => {setAdress(parseInt(event.target.value));};
    const handleChangeFundSource = (event) => {setFundSource(parseInt(event.target.value));};
    const handleChangeFundType = (event) => {setFundType(parseInt(event.target.value));};
    const handleChangeHasJob = (event) => {setHasJob(parseInt(event.target.value));};
    const handleChangeParentsIncome= (event) => {setParentsIncome(parseInt(event.target.value));};
    const handleChangeSiblings = (event) => {setSiblings(parseInt(event.target.value));};
    const handleChangeDependentSiblings = (event) => {setDependentSiblings(parseInt(event.target.value));};
    const handleChangeStrand = (event) => {setStrand(parseInt(event.target.value));};
    const handleChangeJoinedScienceHigh = (event) => {setJoinedScienceHigh(parseInt(event.target.value));};
    const handleChangeWithHonors = (event) => {setWithHonors(parseInt(event.target.value));};
    const handleChangeEnglishGradeRange = (event) => {setEnglishGradeRange(parseInt(event.target.value));};
    const handleChangeMathGradeRange = (event) => {setMathGradeRange(parseInt(event.target.value));};
    const handleChangeScienceGradeRange = (event) => {setScienceGradeRange(parseInt(event.target.value));};
    const handleChangeGpa= (event) => {setGpa(parseInt(event.target.value));};
    const handleChangeCourse= (event) => {setCourse(parseInt(event.target.value));};
    const handleChangeProfessor= (event) => {setProfessor(parseInt(event.target.value));};
    const handleChangeModeOfDelivery= (event) => {setModeOfDelivery(parseInt(event.target.value));};
    const handleChangeHasScholarship= (event) => {setHasScholarship(parseInt(event.target.value));};
    const handleChangeIsInCebu= (event) => {setIsInCebu(parseInt(event.target.value));};
    const handleChangeCurrentStayingPlace= (event) => {setCurrentStayingPlace(parseInt(event.target.value));};
    const handleChangeHasEnoughStudySpace= (event) => {setHasEnoughStudySpace(parseInt(event.target.value));};
    const handleChangeModeTransportGoingHome= (event) => {setModeTransportGoingHome(parseInt(event.target.value));};
    const handleChangeCommuteCountGoingHome= (event) => {setCommuteCountGoingHome(parseInt(event.target.value));};
    const handleChangeCommuteDurationGoingHome= (event) => {setCommuteDurationGoingHome(parseInt(event.target.value));};
    const handleChangeModeTransportGoingSchool= (event) => {setModeTransportGoingSchool(parseInt(event.target.value));};
    const handleChangeCommuteCountGoingSchool= (event) => {setCommuteCountGoingSchool(parseInt(event.target.value));};
    const handleChangeCommuteDurationGoingSchool= (event) => {setCommuteDurationGoingSchool(parseInt(event.target.value));};
    const handleChangeHasDevice= (event) => {setHasDevice(parseInt(event.target.value));};

    const handleSubmit =async(e)=>{
        e.preventDefault();
        try{
            const response = await axios.post(`https://localhost:7025/RetentionRate`,{
                "address": address,
                "fund_Source": fundSource,
                "fund_Type": fundType,
                "hasJob": hasJob,
                "totalParentsIncome": parentsIncome,
                "numberOfSiblings": siblings,
                "numberOfDependentSiblings": dependentSiblings,
                "strand": strand,
                "joinedScienceHighSchool": joinedScienceHigh,
                "withHonors": withHonors,
                "english_Grade_Range": englishGradeRange,
                "math_Grade_Range": mathGradeRange,
                "science_Grade_Range": scienceGradeRange,
                "gpa": gpa,
                "course": course,
                "professor": professor,
                "modeOfDelivery": modeOfDelivery,
                "hasScholarship": hasScholarship,
                "isInCebu": isInCebu,
                "currentStayingPlace": CurrentStayingPlace,
                "hasEnoughStudySpace": HasEnoughStudySpace,
                "modeTransportGoingHome": ModeTransportGoingHome,
                "commuteCountGoingHome": CommuteCountGoingHome,
                "commuteDurationGoingHome": CommuteDurationGoingHome,
                "modeTransportGoingSchool": ModeTransportGoingSchool,
                "commuteCountGoingSchool": CommuteCountGoingSchool,
                "commuteDurationGoingSchool": CommuteDurationGoingSchool,
                // "isShifted": 0,
                "hasDevice": HasDevice,
            });
            const { predictedLabel, score} = response.data;
            setPredictedLabel(predictedLabel);
            setScore(score);
            console.log('Response:', response.data);
        }catch(error){
            console.log('Error posting data:', error);
        }
    }

  return (
        <div className='rcontent'>
            <Typography variant="h3" gutterBottom>
                    Retention Rate Prediction Page
                </Typography>
                <Typography variant="h6" gutterBottom>
                    This page calculates retention rate of students based on historical data.
                </Typography>

                <div className='container'>
                    <div className='rinput-container'>
                    <Typography variant="h6" gutterBottom>
                    Personal Information
                    </Typography>
                        <div className='rinputs'>
                        <div className='rtext'>Address:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={address} label="Choose"autoWidth
                                onChange={handleChangeAddress}>
                                <MenuItem value={1}>Cebu City</MenuItem>
                                <MenuItem value={2}>Cebu Province</MenuItem>
                                <MenuItem value={3}>Outside Cebu</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Fund Source:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={fundSource} label="Choose"autoWidth
                                onChange={handleChangeFundSource}>
                                <MenuItem value={1}>Parents/Guardian</MenuItem>
                                <MenuItem value={2}>Me</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Fund Type:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={fundType} label="Choose"
                                onChange={handleChangeFundType}>
                                <MenuItem value={1}>None</MenuItem>
                                <MenuItem value={2}>Private Work</MenuItem>
                                <MenuItem value={3}>Non-Academic Scholar</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Do you have a job?</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={hasJob}label="Choose"
                                onChange={handleChangeHasJob}>
                                <MenuItem value={1}>Yes</MenuItem>
                                <MenuItem value={0}>No</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Total Parents Income:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={parentsIncome}label=""
                                onChange={handleChangeParentsIncome}>
                                <MenuItem value={1}>Less than 9,100</MenuItem>
                                <MenuItem value={2}>9,100 to 18,200</MenuItem>
                                <MenuItem value={3}>18,200 to 36,400</MenuItem>
                                <MenuItem value={4}>36,400 to 63,700</MenuItem>
                                <MenuItem value={5}>63,700 to 109,200</MenuItem>
                                <MenuItem value={6}>109,200 to 182,000</MenuItem>
                                <MenuItem value={7}>Above 182,000</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                            <div className='rtext'>Total Number of Siblings:</div>
                            <TextField className="formControl"id="outlined-basic" label="00" variant="outlined" value={siblings} onChange={handleChangeSiblings}/>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Total Number of Parent/Guardian-dependent siblings:</div>
                            <TextField className="formControl" id="outlined-basic" label="00" variant="outlined"  value={dependentSiblings} onChange={handleChangeDependentSiblings}/>
                        </div>
                    </div>

                    <div className='rinput-container'>
                    <Typography variant="h6" gutterBottom>
                    SHS Information
                    </Typography>
                        <div className='rinputs'>
                        <div className='rtext'>SHS Strand:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={strand}label=""
                                onChange={handleChangeStrand}>
                                <MenuItem value={1}>STEM</MenuItem>
                                <MenuItem value={2}>ABM</MenuItem>
                                <MenuItem value={3}>GAS</MenuItem>
                                <MenuItem value={4}>HUMMS</MenuItem>
                                <MenuItem value={5}>TVL</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Did you attend in a science high school?</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={joinedScienceHigh}label="Choose"
                                onChange={handleChangeJoinedScienceHigh}>
                                <MenuItem value={1}>Yes</MenuItem>
                                <MenuItem value={0}>No</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Are you with honors? </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={withHonors}label="Choose"
                                onChange={handleChangeWithHonors}>
                                <MenuItem value={1}>Yes</MenuItem>
                                <MenuItem value={0}>No</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>English Grade Range: </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={englishGradeRange}label="Choose"
                                onChange={handleChangeEnglishGradeRange}>
                                <MenuItem value={1}>Less than 85</MenuItem>
                                <MenuItem value={2}>85 – 87</MenuItem>
                                <MenuItem value={3}>88 – 90</MenuItem>
                                <MenuItem value={4}>91 – 93</MenuItem>
                                <MenuItem value={5}>94 – 96</MenuItem>
                                <MenuItem value={6}>97 – 99</MenuItem>
                                <MenuItem value={7}>No Data</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Math Grade Range: </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={mathGradeRange}label="Choose"
                                onChange={handleChangeMathGradeRange}>
                                <MenuItem value={1}>Less than 85</MenuItem>
                                <MenuItem value={2}>85 – 87</MenuItem>
                                <MenuItem value={3}>88 – 90</MenuItem>
                                <MenuItem value={4}>91 – 93</MenuItem>
                                <MenuItem value={5}>94 – 96</MenuItem>
                                <MenuItem value={6}>97 – 99</MenuItem>
                                <MenuItem value={7}>No Data</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Science Grade Range: </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={scienceGradeRange}label="Choose"
                                onChange={handleChangeScienceGradeRange}>
                                <MenuItem value={1}>Less than 85</MenuItem>
                                <MenuItem value={2}>85 – 87</MenuItem>
                                <MenuItem value={3}>88 – 90</MenuItem>
                                <MenuItem value={4}>91 – 93</MenuItem>
                                <MenuItem value={5}>94 – 96</MenuItem>
                                <MenuItem value={6}>97 – 99</MenuItem>
                                <MenuItem value={7}>No Data</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>GPA: </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={gpa}label="Choose"
                                onChange={handleChangeGpa}>
                                <MenuItem value={1}>Less than 85</MenuItem>
                                <MenuItem value={2}>85 – 87</MenuItem>
                                <MenuItem value={3}>88 – 90</MenuItem>
                                <MenuItem value={4}>91 – 93</MenuItem>
                                <MenuItem value={5}>94 – 96</MenuItem>
                                <MenuItem value={6}>97 – 99</MenuItem>
                                <MenuItem value={7}>No Data</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                    </div>

                    <div className='rinput-container'>
                    <Typography className='category' variant="h6" gutterBottom>
                    College Information
                    </Typography>
                        <div className='rinputs'>
                        <div className='rtext'>Course: </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={course}label="Choose"
                                onChange={handleChangeCourse}>
                                <MenuItem value={1}>BS Computer Science</MenuItem>
                                <MenuItem value={2}>BS Information Technology</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Programming 1 professor: </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={professor}label="Choose"
                                onChange={handleChangeProfessor }>
                                <MenuItem value={1}>Frederick Revilleza</MenuItem>
                                <MenuItem value={2}>Jay Vince D. Serato</MenuItem>
                                <MenuItem value={3}>Erica Jean S. Abadinas</MenuItem>
                                <MenuItem value={4}>Cheryl B. Pantaleon</MenuItem>
                                <MenuItem value={5}>Kenn Migan Vincent C. Gumonan</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Mode of Delivery: </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={modeOfDelivery}label="Choose"
                                onChange={handleChangeModeOfDelivery }>
                                <MenuItem value={1}>Face-to-face</MenuItem>
                                <MenuItem value={2}>Hybrid</MenuItem>
                                <MenuItem value={3}>Online</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Do you have a scholarship? </div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={hasScholarship}label="Choose"
                                onChange={handleChangeHasScholarship}>
                                <MenuItem value={1}>Yes</MenuItem>
                                <MenuItem value={0}>No</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Are you currently living in Cebu?</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={isInCebu}label="Choose"
                                onChange={handleChangeIsInCebu}>
                                <MenuItem value={1}>Yes</MenuItem>
                                <MenuItem value={0}>No</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Where are you currently staying?</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={CurrentStayingPlace}label="Choose"
                                onChange={handleChangeCurrentStayingPlace}>
                                <MenuItem value={1}>Home</MenuItem>
                                <MenuItem value={2}>Boarding House</MenuItem>
                                <MenuItem value={3}>Condominium</MenuItem>
                                <MenuItem value={4}>Relative's House</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Do you have enough space/place for studying?</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={HasEnoughStudySpace}label="Choose"
                                onChange={handleChangeHasEnoughStudySpace}>
                                <MenuItem value={1}>Yes</MenuItem>
                                <MenuItem value={0}>No</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Mode of transport going home:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={ModeTransportGoingHome}label="Choose"
                                onChange={handleChangeModeTransportGoingHome}>
                                <MenuItem value={1}>Walk</MenuItem>
                                <MenuItem value={2}>Commute</MenuItem>
                                <MenuItem value={3}>Personal Vehicle</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Number of commutes going home:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={CommuteCountGoingHome}label="Choose"
                                onChange={handleChangeCommuteCountGoingHome}>
                                <MenuItem value={1}>Does not commute</MenuItem>
                                <MenuItem value={2}>1 ride</MenuItem>
                                <MenuItem value={3}>2 rides</MenuItem>
                                <MenuItem value={4}>3 rides</MenuItem>
                                <MenuItem value={5}>4 rides and above</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Commute duration going home:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={CommuteDurationGoingHome}label="Choose"
                                onChange={handleChangeCommuteDurationGoingHome}>
                                <MenuItem value={1}>Less than 30 minutes</MenuItem>
                                <MenuItem value={2}>30 minutes to 1 hour</MenuItem>
                                <MenuItem value={3}>1 hour – 2 hours</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Mode of transport going school:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={ModeTransportGoingSchool}label="Choose"
                                onChange={handleChangeModeTransportGoingSchool}>
                                <MenuItem value={1}>Walk</MenuItem>
                                <MenuItem value={2}>Commute</MenuItem>
                                <MenuItem value={3}>Personal Vehicle</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Number of commutes going school:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={CommuteCountGoingSchool}label="Choose"
                                onChange={handleChangeCommuteCountGoingSchool}>
                                <MenuItem value={1}>Does not commute</MenuItem>
                                <MenuItem value={2}>1 ride</MenuItem>
                                <MenuItem value={3}>2 rides</MenuItem>
                                <MenuItem value={4}>3 rides</MenuItem>
                                <MenuItem value={5}>4 rides and above</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Commute duration going school:</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={CommuteDurationGoingSchool}label="Choose"
                                onChange={handleChangeCommuteDurationGoingSchool}>
                                <MenuItem value={1}>Less than 30 minutes</MenuItem>
                                <MenuItem value={2}>30 minutes to 1 hour</MenuItem>
                                <MenuItem value={3}>1 hour – 2 hours</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                        <div className='rinputs'>
                        <div className='rtext'>Do you have you own device for programming?</div>
                            <FormControl className="formControl">
                                <InputLabel id="select-input">Choose</InputLabel>
                                <Select labelId="select-input" id="select-input" value={HasDevice}label="Choose"
                                onChange={handleChangeHasDevice}>
                                <MenuItem value={1}>Yes</MenuItem>
                                <MenuItem value={0}>No</MenuItem>
                                </Select>
                            </FormControl>
                        </div>
                    </div>
                
                    <div className='rinput-container'>
                        <button onClick={handleSubmit}>Submit Data</button>
                        {/* <h2>Predicted Label</h2>
                        {predictedLabel && (
                            <div>
                                <p>{predictedLabel === 1 ? "true" : "false"}</p>
                            </div>
                            )} */}
                        {score && predictedLabel === 1 && (
                            <div>
                                <h2>Adjusted Score</h2>
                                <p>{(100 - (Math.max(...score) * 100)).toFixed(2)}% Retention Rate</p>
                            </div>
                        )}
                        {score && predictedLabel !== 1 && (
                            <div>
                                <h2>Score</h2>
                                <p>{(Math.max(...score) * 100).toFixed(2)}% Retention Rate</p>
                            </div>
                        )}
                    </div>
                </div>
        </div>
)
}

export default RetentionRate