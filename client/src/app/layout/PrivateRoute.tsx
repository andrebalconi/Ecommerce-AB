import { Navigate, Outlet, useLocation } from "react-router-dom";
import { useAppSelector } from "../store/configureStore";

 
export const PrivateRoutes = () => {
  const location = useLocation();
  const { user } = useAppSelector((state) => state.account);
 
  return !user ? (
    <Navigate replace to="/login" state={{ from: location }} />
  ) : (
    <Outlet />
  );
};