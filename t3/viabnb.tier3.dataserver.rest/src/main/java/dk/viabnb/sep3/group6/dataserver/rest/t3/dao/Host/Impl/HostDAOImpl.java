package dk.viabnb.sep3.group6.dataserver.rest.t3.dao.Host.Impl;

import dk.viabnb.sep3.group6.dataserver.rest.t3.dao.BaseDao;
import dk.viabnb.sep3.group6.dataserver.rest.t3.dao.Host.HostDAO;
import dk.viabnb.sep3.group6.dataserver.rest.t3.models.Host;
import org.springframework.context.annotation.Scope;
import org.springframework.stereotype.Repository;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;



public class HostDAOImpl extends BaseDao implements HostDAO
{

    @Override
    public Host RegisterHost(Host host) {
        return null;
    }

    @Override public Host getHostByEmail(String email)
    {
        return null;
    }

    @Override public Host getHostById(int Id)
    {
        return null;
    }

    @Override public List<Host> getAllHosts()
    {
        return null;
    }

    @Override public List<Host> getAllNotApprovedHosts()
    {
        List<Host> hostsToReturn = new ArrayList<>();
        try(Connection connection = getConnection())
        {
            PreparedStatement stm = connection.prepareStatement
                ("SELECT * FROM viabnb.host WHERE isapproved = ?");
            stm.setBoolean(1, false);
            ResultSet result = stm.executeQuery();
            while (result.next())
            {
                Host hostToAdd = new Host
                    (
                        result.getInt("hostid"),
                        result.getString("fname"),
                        result.getString("lname"),
                        result.getString("phonenumber"),
                        result.getString("email"),
                        result.getString("password"),
                        null,
                        result.getString("personalimage"),
                        result.getString("cprnumber"),
                        result.getBoolean("isapproved")
                    );
                hostsToReturn.add(hostToAdd);
            }
            return hostsToReturn;
        }
        catch (SQLException throwables)
        {
            throwables.printStackTrace();
        }
        return null;
    }

    @Override public Host approveHost(Host host)
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement stm = connection.prepareStatement
                ("UPDATE host SET isapproved = true WHERE hostid = ?");
            stm.setInt(1, host.getId());
            stm.executeUpdate();
            connection.commit();
            return host;
        }
        catch (SQLException throwables)
        {
            throwables.printStackTrace();
        }
        return null;
    }

    @Override public Host rejectHost(Host host)
    {
        try(Connection connection = getConnection())
        {
            PreparedStatement stm = connection.prepareStatement
                ("DELETE FROM host WHERE hostid = ?");
            stm.setInt(1, host.getId());
            stm.executeUpdate();
            connection.commit();
            return host;
        }
        catch (SQLException throwables)
        {
            throwables.printStackTrace();
        }
        return null;
    }
}
