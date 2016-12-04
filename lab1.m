function res = lab1_6( eq )
    %рівняння №13
    if eq == 13
        a=-2;
        b=10;

        x=a:0.00001:b;
        y=f13(x);
    
        plot(x,y)
    
        grid on
        grid minor
        hold on
    
        splot(xOx,yOx,'k')
        splot(xOy,yOy,'k')
    
        fun=@f13;
    
        x=[-1.7,1.2,1.6,4.6,7.8];
        res=vpa(fsolve(fun,x), 9);
        
    %рівняння №28
    elseif eq == 28
        a=-5;
        b=5;
        x=a:0.1:b;
        y=f28(x);
    
        plot(x,y,'g')
    
        grid on
        grid minor
        hold on
    
        xOx=[a b];
        yOx=[0 0];
    
        xOy=[0 0];
        yOy=[-10 10];
    
        plot(xOx,yOx,'k')
        plot(xOy,yOy,'k')
    
        fun=@f28;
        
        x=[0.2, 2.5];
        res=vpa(fsolve(fun,x), 9);
        
    
        
    %поліном
    elseif eq == 7
        p=[-2, 71, -171, -589, 825, 772, -638, -3];
        res=vpa(roots(p), 8);
    end

end

function y = f13(x)
    y = 5 +  x.^7.*sin(x) - x.^13.*cos(x).*sqrt(pi - cos(x.^3.));
end


function y = f28(x)
    y=x.^2. + pi.*log10(13*pi)-5*pi.*sin(x)-2*x;
end


