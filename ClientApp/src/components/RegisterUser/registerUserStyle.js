import { makeStyles } from "@material-ui/core/styles";

const drawerWidth = 240;

export default makeStyles((theme) => ({
  toolbar: theme.mixins.toolbar,
  container: {
    // [theme.breakpoints.up("sm")]: {
    //   marginLeft: drawerWidth,
    //   width: `calc(100% - ${drawerWidth}px)`,
    // },
    backgroundColor: "#E9ECEF",
    minHeight: "100vh",
  },
  paper: {
    marginTop: theme.spacing(8),
    minHeight: "600px",
    padding: "20px",
  },
}));
